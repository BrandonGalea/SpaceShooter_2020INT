using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update


    [SerializeField]

    private float _speed = 4f;
    

    // Update is called once per frame
    void Update()
    {
    // move the enemy down at 4 units per second
    transform.Translate(Vector3.down * _speed * Time.deltaTime);
        if (transform.position.y < -5f) {
            float x = Random.Range(-5f, 5f);
            transform.position = new Vector3(x, 5f, 0);
        }

        // if the position on Y is at the bottom of the screen
        // move to the top
    }

    private void OnTriggerEnter(Collider other)
    {
        
        // if the "other" object's tag is Player
        // damage the player
        // destroy this gameobject

        // if the "other" object's tag is laser
        // destroy the laser
        //destroy the gameobject

    }
}
