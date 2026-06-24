using UnityEngine;

/// <summary>
/// Attached to the WelcomePanel root GameObject.
/// Shows the panel on launch, optionally pauses the game clock,
/// and hides the panel + resumes play when the Start button is clicked.
/// </summary>
public class WelcomeController : MonoBehaviour
{
    [Tooltip("Pause game time while the welcome panel is visible. " +
             "Head tracking and controller rays are unaffected by timeScale. " +
             "Disable this if it causes issues on-device.")]
    public bool pauseWhileVisible = true;

    void Awake()
    {
        gameObject.SetActive(true);
        if (pauseWhileVisible)
            Time.timeScale = 0f;
    }

    /// <summary>
    /// Wire this to the Start button's onClick event in the Inspector.
    /// </summary>
    public void OnStartClicked()
    {
        if (pauseWhileVisible)
            Time.timeScale = 1f;
        gameObject.SetActive(false);
    }
}
