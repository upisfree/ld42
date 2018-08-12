using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Game : MonoBehaviour {
    void Start () {
        SceneManager.DisableAll();

        SceneManager.Enable(SceneManager.Scenes[0]);

        StartCoroutine(HideStartScreen());
	}
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.R)) {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
        }
	}

    IEnumerator HideStartScreen() {
        yield return new WaitForSeconds(7);

        GameObject.Find("UI").SetActive(false);
        GameObject.Find("Player").GetComponent<FirstPersonController>().enabled = true;
    }
}
