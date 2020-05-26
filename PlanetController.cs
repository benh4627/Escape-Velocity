using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetController : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        if (player.transform.position.x > transform.position.x + 6)
        {
            Vector3 newposition = new Vector3(Random.Range(player.transform.position.x - 5.6f, player.transform.position.x + 5.6f), transform.position.y, 0);
            var checkResult = Physics2D.OverlapCircle(newposition, 5);
            if (checkResult == null)
            {
                gameObject.transform.position = newposition;
            }
        }
        if (player.transform.position.x < transform.position.x - 6)
        {
            transform.position = new Vector2(transform.position.x - 16.944f, transform.position.y);
        }
        if (player.transform.position.y > transform.position.y + 15)
        {
            Vector3 newposition = new Vector3(transform.position.x, Random.Range(player.transform.position.y + 10, player.transform.position.y + 30), 0);
            var checkResult = Physics2D.OverlapCircle(newposition, 5);
            if (checkResult == null)
            {
                transform.position = newposition;
            }

        }
    }
}