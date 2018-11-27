using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn: MonoBehaviour {

    public GameObject Restart;

    private PlayerController Player;

    public float minHeightForDeath;

    void Start (){

       
    }
    //public void RespawnPlayer(){
    void Update()
    {
    
        if (transform.position.y < minHeightForDeath)
        {
            transform.position = Restart.transform.position;
        }
       
    } 

}