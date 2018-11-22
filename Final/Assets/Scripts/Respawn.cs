using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn: MonoBehaviour {

    public GameObject Restart;

    private PlayerController Player;

    public float minHeightForDeath;

    void Start (){

       
    }
    public void RespawnPlayer(){
        if (Player.transform.position.y < minHeightForDeath)
        {
            Player.transform.position = Restart.transform.position;
        }
       
    } 

}