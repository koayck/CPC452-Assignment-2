# CPC452 Assignment 2 Requirements 

Toxland VR: Hop & Help — Meta Quest to PICO 4 Conversion Project Requirements

## Deadline

- Final submission: Friday, 26 June 2026
- Submit a compressed zip file containing: APK file, Unity project source, and final report
- A recorded presentation explaining and demonstrating the work must also be submitted (separately marked)

## Project Description

**Toxland VR: Hop & Help** is an educational Virtual Reality game that teaches young children about the safe handling, storage, and awareness of toxic or hazardous household materials. Inspired by Snakes and Ladders, players act as Junior Safety Rangers, moving across a giant interactive board through rooms (kitchen, bathroom, laundry area, garden, storage room) and making safety decisions about items such as cleaning chemicals, batteries, medicines, detergents, pesticides, and aerosol sprays.

- Good Practice Spaces (Ladders): correct safety actions (e.g. locking medicine away, reading warning labels, wearing gloves) reward bonus movement
- Bad Practice Spaces (Toxic Traps): unsafe actions (e.g. drinking from unlabeled containers, mixing chemicals, leaving products on the floor) trigger penalties and educational warnings
- Learning Cards: safety tips, fun facts, mini quizzes, hazard identification challenges
- Score System: points for correct safety decisions, quiz answers, hazard identification, and game completion
- End Goal: reach the Safety Champion Zone with the highest score

The provided source code is built in Unity3D with the Meta SDK, targeting the Meta Quest headset. The project requires converting and adapting this Meta Quest-based VR application into an XR-compatible/PICO-supported build that runs on the **PICO 4** headset.

### Conversion Scope

- Update Unity XR settings
- Replace/reconfigure Meta Quest-specific SDK components
- Integrate the PICO XR SDK
- Ensure compatibility (input system, controller interactions, camera rig, locomotion, UI interaction, Android build settings) with PICO 4 deployment
- Test the APK on a physical PICO 4 device
- Document technical challenges encountered during migration

## Required Report Contents

The report must clearly explain:

- The conversion workflow
- Original Meta Quest dependencies identified
- Changes made for XR/PICO compatibility and the SDKs used
- Testing procedures
- Evidence that the converted application works on the target platform (PICO 4)
- Storyboard, concept drawings, storyline, and target audience justification
- Level design plan and minimum system requirements
- A user manual for operating the VR app
- The application's theme (educational, entertainment, training, or hybrid) and target audience (children, teens, or adults)

## Team Structure

| Role | Responsibility |
|---|---|
| Project Director | Project planning and management |
| Programmer | Unity scripting, game logic, scoring system |
| 3D Artist | Board design, household objects, environment |
| Animator | Character and object animations |
| UI/UX Designer | Menus, educational interfaces, feedback systems |

## Suggested Report Structure (Rubrics)

1. **Abstract (100–150 words)** — VR title, concept, target audience, objectives, technical platform (Unity3D, OpenVR, PICO SDK)
2. **VR Concept** — Project name, concept theme, target audience, storyline & world design, storyboard (4–6 frames/images), team structure table
3. **Background Study** — Compare 2–3 existing similar VR games/applications related to child safety education, hazard awareness, interactive learning, and serious games (e.g. Safety Town VR, Hazard Patrol Educational Games, Virtual Safety House) on purpose, platform, and interaction model; explain how this project builds on or innovates beyond them
4. **Methodology** — Platform & SDKs used (Unity3D, PICO SDK, OpenVR); minimum specs (PICO 4, Android 10+, 1GB storage, joypad/crosshair input); system architecture (flowchart/block diagram); level design (single-floor plan, key interactive zones)
5. **System Development** — Navigation control (joystick or gaze-based), interaction system (grab, hit, manipulate), scoring/timing system, welcome & end screens, sound & feedback, Unity gameplay screenshots
6. **Conclusion** — Challenges faced (SDK bugs, asset imports, PICO setup), proposed/implemented solutions, suggestions for future improvement
7. **Extra: VR Prototype (Screenshots)** — 4–6 screenshots covering welcome screen, in-game interaction, and end screen/feedback popup (to demonstrate functionality even if the APK can't be demoed live)

## Presentation Criteria (Recorded Video — Separately Marked)

1. Introduction of concept, target audience, platform
2. Detailed team structure with roles
3. Game/VR system concept + storyboard explanation
4. Functional demonstration (via screen record)
5. Participation from all team members

## Submission Package

Submit one compressed zip file containing:

- APK file
- Unity project source
- Final report

Evaluation is based on three major parts:

1. Functionality and immersion of the VR experience
2. Completeness and quality of the submission components
3. Clarity and depth of the report content (conceptual and technical elaboration)

The recorded presentation contributes to the overall score.

## Installers

- Unity (Win/Mac): https://store.unity.com/download?ref=personal
- Android Studio / Unity Android SDK setup: https://docs.unity3d.com/Manual/android-sdksetup.html
- PICO XR SDK: https://developer.picoxr.com/resources/
- Google VR SDK: https://github.com/googlevr/gvr-unity-sdk/releases

## Online Resources

- Getting Started with VR Development: https://unity3d.com/learn/tutorials/topics/virtual-reality/getting-started-vr-development
