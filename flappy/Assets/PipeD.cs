using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeD : MonoBehaviour {

    private Character character;

    // Use this for initialization
    void Start()
    {
        character = FindObjectOfType<Character>(); //where the character is
    }

    // Update is called once per frame
    void Update()
    {
        if (character.transform.position.x - transform.position.x > 30) //if character is certain dist away from the downwards pipe,it will be destroyed
        {
          Destroy(gameObject);
        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            character.Death();
        }

    }

}
