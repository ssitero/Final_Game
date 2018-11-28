using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaSiRespawn : MonoBehaviour {

    public GameObject Restart;

    private SaSiPlayerController Player;

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