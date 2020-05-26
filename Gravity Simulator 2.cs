using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySimulator2 : MonoBehaviour
{

    public float maxGravDist = 4.0f; //maximum distance player can be from object with grav force
    public float maxGravity = 15.0f; //maximum gravity that can be applied by an object
    GameObject player;


    void FixedUpdate()
    {
        //for each object with Planet tag
            float dist = Vector3.Distance(transform.position, player.transform.position); //distance between planet and player
            if (dist <= maxGravDist) //if the distance between planet and player is less than the maximum distance to apply gravity...
            {
                Vector3 v = transform.position - player.transform.position; //store this distance as a vector3, v
                GetComponent<Rigidbody2D>().AddForce(v.normalized * (1.0f - dist / maxGravDist) * maxGravity);
                //apply a force to the rigidbody by normalizing v(making it unit vector)
        }
    }
}
