using UnityEngine;

public class SceneManager : MonoBehaviour {
    public static string[] Scenes = {
        "GramophoneScene",
        "DoorScene",
        "WallScene",
        "ShootingScene",
        "EndScene"
    };

    public static void Enable(string name) {
        ChangeStatus(name, true);
    }

    public static void Disable(string name) {
        ChangeStatus(name, false);
    }

    public static void EnableAll() {
        foreach (string s in Scenes) {
            SceneManager.Enable(s);
        }
    }

    public static void DisableAll() {
        foreach (string s in Scenes) {
            SceneManager.Disable(s);
        }
    }

    private static void ChangeStatus(string name, bool isEnabled) {
        if (name == null || name == "") {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Game");

            return;
        }

        Light[] lights = GameObject.Find(name).GetComponentsInChildren<Light>();
        Animator[] animators = GameObject.Find(name).GetComponentsInChildren<Animator>();
        AudioSource[] audios = GameObject.Find(name).GetComponentsInChildren<AudioSource>();

        foreach (Light a in lights) {
            a.enabled = isEnabled;
        }

        foreach (Animator b in animators) {
            b.enabled = isEnabled;
        }

        foreach (AudioSource c in audios) {
            c.enabled = isEnabled;
        }
    }
}
