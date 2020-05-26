using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBackground : MonoBehaviour
{
    public GameObject player;
    private Vector2 speed;

    private void Start()
    {
        speed = new Vector2(0, -2);
    }
    private void Update()
    {
       GetComponent<Rigidbody2D>().velocity = speed;
        if (player.transform.position.y > transform.position.y + 30)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + 86.8552f);
        }
    }
}