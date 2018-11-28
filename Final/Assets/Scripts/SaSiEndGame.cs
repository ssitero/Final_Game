using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaSiEndGame : MonoBehaviour {

    public Text endtext;


    // Use this for initialization
    void Start () {

       // endtext.text.SetActive(false);

    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
           
         //   endtext.text.SetActive(true);
            endtext.text = "You Win!";

        }
       
    }

}
