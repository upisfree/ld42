using System.Collections;
using System.Collections.Generic;
using LD42;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Game : MonoBehaviour {
    public bool isGameStarted = false;

    void Start () {
        SceneManager.DisableAll();

        SceneManager.Enable(SceneManager.Scenes[0]);

        StartCoroutine(HideStartScreen());
	}
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.R)) {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
        }

        if (isGameStarted && Input.anyKeyDown && GameObject.Find("UI")) {
            GameObject.Find("UI").SetActive(false);
            GameObject.Find("Player").GetComponent<FPS>().enabled = true;
        }
	}

    IEnumerator HideStartScreen() {
        yield return new WaitForSeconds(1);

        isGameStarted = true;

        //GameObject.Find("UI").SetActive(false);
        //GameObject.Find("Player").GetComponent<FPS>().enabled = true;
    }
}