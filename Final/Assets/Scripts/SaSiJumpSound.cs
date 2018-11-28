using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaSiJumpSound : MonoBehaviour {

    public AudioSource Jump;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow)){
            Jump.Play();
        }
	}
}
