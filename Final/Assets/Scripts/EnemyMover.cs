using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{


   
    float speed = 5f;

    float height = 0.5f;

    void Update()
    {
      
        Vector3 pos = transform.position;
      
        float newY = Mathf.Sin(Time.time * speed);

        transform.position = new Vector3(pos.x, newY, pos.z) * height;
    }
}