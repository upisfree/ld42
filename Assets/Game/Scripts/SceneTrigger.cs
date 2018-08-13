using System.Collections;
using System.Collections.Generic;
using LD42;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class SceneTrigger : MonoBehaviour {
    public string SceneToEnableName;
    public GameObject PlayerSpawnPoint;
    public GameObject PlayerSpawnPointLookAt;
    public float Delay = 10;
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
        var player = GameObject.Find("Player");

        if (DisableAllScenesOnTrigger) {
            SceneManager.DisableAll();
        }

        SceneManager.Enable(SceneToEnableName);

        if (PlayerSpawnPoint && PlayerSpawnPointLookAt) {
            player.transform.position = PlayerSpawnPoint.transform.position;
            player.transform.LookAt(PlayerSpawnPointLookAt.transform);
        }

        if (SceneToEnableName == "WallScene") {
            AudioSource[] fpsAudios = player.GetComponentsInChildren<AudioSource>();

            foreach (AudioSource a in fpsAudios) {
                a.enabled = true;
            }
        }
    }

    IEnumerator ManageScenesWithDelay() {
        yield return new WaitForSeconds(Delay);

        ManageScenes();
    }
}
