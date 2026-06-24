// Phase 5 helper — run once after Phase 4, then keep or delete this file.
// Menu: Tools → PICO Migration → Fix Canvas UI Raycasters (XRI)
//
// What it does:
//   • Finds every World-Space Canvas in the active scene (including inactive ones,
//     because quiz canvases are toggled off at runtime).
//   • Removes missing-script components from each Canvas GameObject
//     (the dead OVRRaycaster left behind when Assets/Oculus/ was deleted).
//   • Adds TrackedDeviceGraphicRaycaster so XRI controller rays can click the UI.
//   • Creates an EventSystem + XRUIInputModule if none exists.
//   • Marks the scene dirty (save with Ctrl+S after running).

using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit.UI;

public static class PicoUIMigration
{
    [MenuItem("Tools/PICO Migration/Fix Canvas UI Raycasters (XRI)")]
    public static void FixCanvasRaycasters()
    {
        Scene scene = SceneManager.GetActiveScene();

        int canvasesProcessed = 0;
        int missingRemoved = 0;
        int raycasterAdded = 0;

        // ── 1. Visit every Canvas in the scene ─────────────────────────────
        foreach (var root in scene.GetRootGameObjects())
        {
            foreach (var canvas in root.GetComponentsInChildren<Canvas>(includeInactive: true))
            {
                // Leave the IngameDebugConsole overlay canvas alone.
                if (canvas.renderMode != RenderMode.WorldSpace)
                    continue;

                GameObject go = canvas.gameObject;
                canvasesProcessed++;

                // Remove dead OVRRaycaster (and any other missing scripts).
                int removed = GameObjectUtility.RemoveMonoBehavioursWithMissingScript(go);
                missingRemoved += removed;

                // Add TrackedDeviceGraphicRaycaster if not already present.
                if (go.GetComponent<TrackedDeviceGraphicRaycaster>() == null)
                {
                    Undo.AddComponent<TrackedDeviceGraphicRaycaster>(go);
                    raycasterAdded++;
                }
            }
        }

        // ── 2. Ensure one EventSystem + XRUIInputModule ────────────────────
        bool esCreated = false;
#pragma warning disable CS0618
        EventSystem existing = Object.FindObjectOfType<EventSystem>();
#pragma warning restore CS0618
        if (existing == null)
        {
            // Create a fresh EventSystem GameObject.
            GameObject esGO = new GameObject("EventSystem");
            Undo.RegisterCreatedObjectUndo(esGO, "Create XR EventSystem");
            Undo.AddComponent<EventSystem>(esGO);
            Undo.AddComponent<XRUIInputModule>(esGO);
            esCreated = true;
        }
        else
        {
            // Upgrade an existing EventSystem: swap StandaloneInputModule for XRUIInputModule.
            StandaloneInputModule sim = existing.GetComponent<StandaloneInputModule>();
            if (sim != null)
                Undo.DestroyObjectImmediate(sim);

            if (existing.GetComponent<XRUIInputModule>() == null)
                Undo.AddComponent<XRUIInputModule>(existing.gameObject);
        }

        EditorSceneManager.MarkSceneDirty(scene);

        Debug.Log(
            $"[PicoUIMigration] Processed {canvasesProcessed} World-Space canvases. " +
            $"Missing scripts removed: {missingRemoved}. " +
            $"TrackedDeviceGraphicRaycasters added: {raycasterAdded}. " +
            $"EventSystem: {(esCreated ? "CREATED" : "already exists (upgraded to XRUIInputModule)")}. " +
            ">>> Save the scene now with Ctrl+S <<<");
    }
}
