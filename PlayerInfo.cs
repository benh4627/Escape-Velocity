using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerInfo : MonoBehaviour
{

    public int playerGems = 0;
    //  public GameObject GemsUI;
    public TextMeshProUGUI distance;
    private float playerDistance = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float playerpos = transform.position.y * 10;
        if (transform.position.y > 0 && playerpos > playerDistance)
            playerDistance += ((int)playerpos - playerDistance);
        distance.text = (playerDistance.ToString());
        //GemsUI.gameObject.GetComponent<TextMeshProUGUI>().text = ("     " + playerGems.ToString());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Gem"))
        {
            playerGems = playerGems + 1;
            Destroy(collision.gameObject);
            Debug.Log(playerGems);
        }

        if (collision.gameObject.CompareTag("Planet"))
        {
            playerDistance = 0;
        }
    }
}
