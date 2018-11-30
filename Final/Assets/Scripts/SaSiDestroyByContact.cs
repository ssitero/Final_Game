using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaSiDestroyByContact : MonoBehaviour
{
    public AudioSource Pop;
    public GameObject Loss;

    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player"){

            Destroy(other.gameObject);
            Instantiate(Loss, transform.position, Quaternion.identity);
            Pop.Play();
           

        }

    }

}