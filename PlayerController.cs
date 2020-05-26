//new
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public int playerSpeed = 2;
    public float maxSpeed;
   // public TextMeshProUGUI winText;
   // public TextMeshProUGUI attemptText;
   // public TextMeshProUGUI coinsText;
    public GameObject player;
    public GameObject camera;
    private float moveX;
    private float moveY;
    private float attempt = 1;
    public GameObject fire;
    int gameStatus = 1;


    private void Start()
    {
        //    winText.text = "";
        //    attemptText.gameObject.GetComponent<TextMeshProUGUI>().text = ("Attempt 1");
    }

    // Use this for initialization
    void Update()
    {
        GeneralMovement();
        GetComponent<Rigidbody2D>().velocity = Vector3.ClampMagnitude(GetComponent<Rigidbody2D>().velocity, maxSpeed);
        if (Input.GetKeyDown("r"))
            Winner();
        

    }

    void GeneralMovement()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveX, moveY);
        GetComponent<Rigidbody2D>().AddForce(movement * playerSpeed);
        if (movement != new Vector2(0,0))
        {
            fire.SetActive(true);
        }
        else
        {
            fire.SetActive(false);
        }
        //Rotation
        Vector2 moveDirection = gameObject.GetComponent<Rigidbody2D>().velocity; //uses velocity of rb2d to find direction of movement
        if (moveDirection != Vector2.zero) //if the velocity is not zero
        {
            float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg; //angle is arctan converted to degrees
            transform.rotation = Quaternion.AngleAxis((angle - 90), Vector3.forward); //rotation
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Planet"))
        {
            gameObject.SetActive(false);
            Invoke("Loser", 1);
            attempt++;
       //     attemptText.gameObject.GetComponent<TextMeshProUGUI>().text = ("Attempt " + attempt.ToString());
        }
        /*  if (collision.gameObject.CompareTag("EndLevel"))
           {
               Debug.Log(gameObject.transform.position.y);
               gameObject.SetActive(false);
               winText.text = "MISSION SUCCESSFUL!";
               Invoke("Winner", 10);
           }*/

        if (collision.gameObject.CompareTag("Invisible Wall"))
        {
            if (player.transform.position.x < 0)
                player.transform.position = new Vector2(7.6f, player.transform.position.y);
            else if (player.transform.position.x > 0)
                player.transform.position = new Vector2(-7.6f, player.transform.position.y);
        }
    }

    private void Winner()
    {
        SceneManager.LoadScene("menu");
    }

    private void Loser()
    {
        SceneManager.LoadScene("menu");
    }

   
}
