using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGenerator : MonoBehaviour
{

    private int level;
    public GameObject player;
    public GameObject planet;
    private int planetDensity;
    public GameObject bg1, bg2, bg3;
    private int totalPlanets;
    public GameObject planet1, planet2, planet3;
    private int i;

    // Use this for initialization
    void Start()
    {
        level = 0;
        planet1.transform.position = new Vector3(Random.Range(-1.8f, 1.8f), Random.Range(5, 8), 0);
        Instantiate(planet1, new Vector3(Random.Range(-7.5f, 7.5f), Random.Range(10.5f, 19), 0), Quaternion.identity);
        Instantiate(planet1, new Vector3(Random.Range(-7.5f, 7.5f), Random.Range(20, 29), 0), Quaternion.identity);
        Vector3 newposition2 = new Vector3(Random.Range(-7.5f, 7.5f), Random.Range(30.5f, 39), 0);
        var checkResult = Physics2D.OverlapCircle(newposition2, 0.7f);
        if (checkResult == null)
        {
            planet2.transform.position = newposition2;
        }
        Vector3 newposition3 = new Vector3(Random.Range(-7.5f, 7.5f), Random.Range(50, 59), 0);
        var checkResult2 = Physics2D.OverlapCircle(newposition2, 0.7f);
        if (checkResult2 == null)
        {
            planet3.transform.position = newposition3;
        }
        i = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        level = (int)(player.transform.position.y * 10) / 100 + 1;
        planetDensity = level * 3;
        if (GameObject.FindGameObjectsWithTag("Planet").Length < level * 3)
        {
            GeneratePlanets();
        }

    }
    private void GeneratePlanets()
    {
        
       /* GameObject bgleft, bgright;
        if (bg1.transform.position.x > bg2.transform.position.x && bg1.transform.position.x > bg3.transform.position.x)
        {
            bgright = bg1;
            if (bg2.transform.position.x > bg3.transform.position.x)
                bgleft = bg3;
            else bgleft = bg2;
        }
        else if (bg2.transform.position.x > bg1.transform.position.x && bg2.transform.position.x > bg3.transform.position.x)
        {
            bgright = bg2;
            if (bg1.transform.position.x > bg3.transform.position.x)
                bgleft = bg3;
            else bgleft = bg1;
        }
        else
        {
            bgright = bg3;
            if (bg1.transform.position.x > bg2.transform.position.x)
                bgleft = bg2;
            else bgleft = bg1;
        }*/
            Vector3 newposition = new Vector3(Random.Range(player.transform.position.x - 5.6f, player.transform.position.x + 5.6f), Random.Range(player.transform.position.y + 10, player.transform.position.y + 50), 0);
            var checkResult = Physics2D.OverlapCircle(newposition, 0.7f);
        if (checkResult == null)
        {
            Instantiate(planet, newposition, Quaternion.identity);
            i++;
          //  Debug.Log(i);
            if (i % 5 == 0)
            {
                Vector3 newposition2 = new Vector3(Random.Range(player.transform.position.x - 5.6f, player.transform.position.x + 5.6f), Random.Range(player.transform.position.y + 10, player.transform.position.y + 50), 0);
                var checkResult2 = Physics2D.OverlapCircle(newposition2, 0.7f);
                if (checkResult2 == null)
                {
                    Instantiate(planet2, newposition2, Quaternion.identity);
                }
            }
            if (i % 10 == 0)
            {
                Vector3 newposition3 = new Vector3(Random.Range(player.transform.position.x - 5.6f, player.transform.position.x + 5.6f), Random.Range(player.transform.position.y + 10, player.transform.position.y + 50), 0);
                var checkResult3 = Physics2D.OverlapCircle(newposition3, 0.7f);
                if (checkResult3 == null)
                {
                    Instantiate(planet3, newposition3, Quaternion.identity);
                }
            }
        }

    }
}
