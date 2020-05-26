using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundGenerator : MonoBehaviour {

    public GameObject player;
   // public GameObject colliders;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		if (player.transform.position.y > transform.position.y + 50)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + 86.8552f);
          //  colliders.transform.position = new Vector2(colliders.transform.position.x, colliders.transform.position.y + 8.9958333f);
                
        }
      /*  if (player.transform.position.x > transform.position.x + 6)
        {
            transform.position = new Vector2(transform.position.x + 10.5f, transform.position.y);
        }
        if (player.transform.position.x < transform.position.x - 6)
        {
            transform.position = new Vector2(transform.position.x - 10.5f, transform.position.y);
        }*/
    }
}
