using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Subtitles : MonoBehaviour {
    public Dictionary<float, string> subtitles = new Dictionary<float, string>() {
        { 0, "Fall in!" },
        { 3, "Right dress!" },
        { 6.5f, "Ready!" },
        { 10, "Take aim!" },
        { 12.5f, "Fire!" }
    };

    public float ClearDelay = 1.2f;

	void Start() {
        foreach (var i in subtitles) {
            StartCoroutine(ShowSub(i.Key, i.Value));
        }
	}

    IEnumerator ShowSub(float delay, string sub) {
        yield return new WaitForSeconds(delay);

        GetComponent<Text>().text = sub;

        StartCoroutine(ClearSub(ClearDelay));
    }

    IEnumerator ClearSub(float delay) {
        yield return new WaitForSeconds(delay);

        GetComponent<Text>().text = "";
    }
}
