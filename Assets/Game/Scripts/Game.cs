using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {
    void Start () {
        SceneManager.DisableAll();

        SceneManager.Enable(SceneManager.Scenes[0]);		
	}
	
	void Update () {
		
	}
}
