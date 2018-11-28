using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaSiDestroyByContact : MonoBehaviour
{
    public AudioSource Pop;
    public Transform blast;

    // Use this for initialization
    void Start()
    {
        blast.GetComponent<ParticleSystem>().enableEmission = false;
    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player"){

            Destroy(other.gameObject);
            Pop.Play();
            blast.GetComponent<ParticleSystem>().enableEmission = true;

        }

    }

}