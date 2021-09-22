﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    public Rigidbody2D rb; //physics attached to the character(bird)
    public float moveSpeed; // variables for speed and height
    public float flapHeight;
    public GameObject pipe_up;
    public GameObject pipe_down;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>(); //for unity to know where the character is
        BuildLevel();
    }
       

    public void BuildLevel() //adding more pipes
    {
        Instantiate(pipe_down, new Vector3(14, 12), transform.rotation);
        Instantiate(pipe_up, new Vector3(14, -11), transform.rotation);

        Instantiate(pipe_down, new Vector3(26, 14), transform.rotation);
        Instantiate(pipe_up, new Vector3(26, -10), transform.rotation);

        Instantiate(pipe_down, new Vector3(38, 10), transform.rotation);
        Instantiate(pipe_up, new Vector3(38, -14), transform.rotation);

        Instantiate(pipe_down, new Vector3(50, 16), transform.rotation);
        Instantiate(pipe_up, new Vector3(50, -8), transform.rotation);

        Instantiate(pipe_down, new Vector3(61, 11), transform.rotation);
        Instantiate(pipe_up, new Vector3(61, -13), transform.rotation);

    }
      

     // Update is called once per frame
     void Update () {
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y); //gives velocity to the bird 
        if (Input.GetMouseButtonDown(0)) //when clicked on it, it will move forward
        {
            rb.velocity = new Vector2(rb.velocity.x, flapHeight);
        }

        if (transform.position.y > 18 || transform.position.y < -19) //if the bird is way too high or way too low, it will die
        {
            Death();
        }

    }

    public void Death() 
    {
        rb.velocity = Vector3.zero;
        transform.position = new Vector2(0, 0); //when respawned , it will start with 0 velocity
    }

}