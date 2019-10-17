using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private float _speed = 8f;
    // Start is called before the first frame update
    void Start()
    {

    
}

    // Update is called once per frame
    void Update()
    {
        // Vector3.right = new Vector3(1, 0, 0)
        transform.Translate(Vector3.up  *_speed * Time.deltaTime);

        // if the laser position on y is greater than 7 you want to destroy the object
        // destroy object
        
    if (transform.position.y > 7)
        {
            Destroy(this.gameObject);
        }
    }
}
