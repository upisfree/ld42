using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTrigger : MonoBehaviour {
    public string SceneToEnableName;
    public int Delay = 10;
    public bool DisableAllScenesOnTrigger = true;

    private void OnTriggerEnter(Collider other) {
        if (Delay > 0) {
            StartCoroutine(ManageScenesWithDelay());
        } else {
            ManageScenes();
        }
    }

    private void OnTriggerStay(Collider other) {
        
    }

    private void OnTriggerExit(Collider other) {
        
    }

    private void ManageScenes() {
        if (DisableAllScenesOnTrigger) {
            SceneManager.DisableAll();
        }

        SceneManager.Enable(SceneToEnableName);
    }

    IEnumerator ManageScenesWithDelay() {
        yield return new WaitForSeconds(Delay);

        ManageScenes();
    }
}
