﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Typer : MonoBehaviour {
    public string msg = "Replace";
    private Text textComp;
    public float startDelay = 1f;
    public float typelDelay = 0.01f;
    public AudioClip putt;


    void Start() {
        StartCoroutine("TypeIn");
    }

	// Use this for initialization
    void Awake() {
        textComp = GetComponent<Text>();
    }

    public IEnumerator TypeIn() {
        yield return new WaitForSeconds(startDelay);

        for(int i = 0; i < msg.Length; i++) {
        textComp.text = msg.Substring(0,i);
        GetComponent<AudioSource>().PlayOneShot(putt);
            yield return new WaitForSeconds(typelDelay);
        }
    }

    public IEnumerator TypeOff() {
        for (int i = msg.Length ; i>=0 ; i--){
            textComp.text = msg.Substring(0,i);
            yield return new WaitForSeconds(typelDelay);
        }
    }
}
