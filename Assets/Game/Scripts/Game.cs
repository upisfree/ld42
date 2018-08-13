using UnityEngine;

public class Game : MonoBehaviour {
    void Start () {
        SceneManager.DisableAll();

        SceneManager.Enable(SceneManager.Scenes[0]);
	}
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.R)) {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
        }
    }
}