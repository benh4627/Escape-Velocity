using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemGenerator : MonoBehaviour
{

    private int level;
    private int update;
    public GameObject gem;

    private void Start()
    {
        level = 0;
        update = 1;
        InvokeRepeating("GenerateGems", 0, 2);
    }

    void Update()
    {
        /*if (transform.position.x > gem.transform.position.x + 6)
        {
            Vector3 newposition = new Vector3(Random.Range(transform.position.x - 5.6f, transform.position.x + 5.6f), gem.transform.position.y, 0);
            var checkResult = Physics2D.OverlapCircle(newposition, 5);
            if (checkResult == null)
            {
                gameObject.transform.position = newposition;
            }
        }
        if (transform.position.x < gem.transform.position.x - 6)
        {
            gem.transform.position = new Vector2(transform.position.x - 16.944f, transform.position.y);
        }*/
    }

    void GenerateGems()
    {
        update++;
        //for (int i = 0; i < 3; i++)
       // {
           Vector3 gemposition = new Vector3(Random.Range(transform.position.x - 3.5f, transform.position.x + 3.5f), Random.Range(transform.position.y + 10, transform.position.y + 30), 0);
            var checkResult = Physics2D.OverlapCircle(gemposition, 1);
            if (checkResult == null)
            {
                Instantiate(gem, gemposition, Quaternion.identity);
            }
        
    }
}