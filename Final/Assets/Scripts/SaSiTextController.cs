using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaSiTextController : MonoBehaviour
{

    //public GUIText instructionsText;
    public Text instructionText;

    void Start()
    {
        instructionText.text = "Reach the end!";
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