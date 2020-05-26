using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemController : MonoBehaviour {

    public GameObject player;

	// Update is called once per frame
	void Update () {
        if (player.transform.position.x > transform.position.x + 6)
        {
            transform.position = new Vector2(transform.position.x + 16.944f, transform.position.y);
        }
        if (player.transform.position.x < transform.position.x - 6)
        {
            transform.position = new Vector2(transform.position.x - 16.944f, transform.position.y);
        }
       // if (player.transform.position.y > transform.position.y + 10)
        {
           // Destroy(gameObject);
        }
    }
}
