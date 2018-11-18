using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextController : MonoBehaviour
{

     public GUIText instructionsText;

    void Start()
    {
        instructionsText.text = "Reach the end!";
        Time.timeScale = 0;
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            Time.timeScale = 1;
            Destroy(gameObject);
        }
    }

}