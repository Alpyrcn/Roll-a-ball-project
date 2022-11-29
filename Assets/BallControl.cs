using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallControl : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    int score = 0;
    public Text scoreText;
    public AudioSource Coin;
   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        float horizon = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 vector = new Vector3(horizon, 0, vertical);

        rb.AddForce(vector*speed);

        
    }

    void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        score++;
        Coin.enabled = true;
        scoreText.text = "" + score;
        
   

        
    }


}
