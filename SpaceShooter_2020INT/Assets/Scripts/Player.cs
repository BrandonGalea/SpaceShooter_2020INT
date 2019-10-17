using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// MonoBehaviour is a Unity class that allows us to attach scripts to GameObjects.
// The colon symbol means that the player inherits MonoBehavior's code.

public class Player : MonoBehaviour
{
    /* Variable is a box with information that can be changed.
     Step 1 : identify if the variable is going to be public or private.
     private variable can only be seen by the class itself
     Step 2: data type (int (whole numbers), 
                        float(numbers number with a point 5.6), 
                        bool(true of false), 
                        string(text))
    every variable needs a name
    Step 4: optional value               
*/

    [SerializeField]

    //attribute - exposes the variable inside Unity
    private float _speed = 3.5f;

    [SerializeField]

    private GameObject _laserPrefab;

    [SerializeField]

    private float _fireRate = 0.15f;

    private float _nextFire = -1.0f;


    // Start is called before the first frame update

    void Start()

    {
        transform.position = new Vector3(0, 0, 0);
    }


    // Update is called once per frame
    void Update()
    {
        CalculatingMovement();

        // if i hit the space key
        // spawn laser
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > _nextFire)
        {
            FireLaser();
        }
    }
    void CalculatingMovement()
    {
        // local variable - horizontalInput
        // read the keyboard input from the user
        float horizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");


        // Vector3.right = new Vector3(1, 0, 0)S

        // Move the player vertically.

        transform.Translate(Vector3.up * VerticalInput * Time.deltaTime, Space.World);
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime, Space.World);


        // if the player position on the y axis is > 0
        // y position = 0
        // else if the Y position < -4.5
        // y position = -4.5
        if (transform.position.y > 0)
        {
            transform.position = new Vector3(transform.position.x, 0, 0);
        }

        else if (transform.position.y < -4.5f)
        {
            transform.position
                = new Vector3(transform.position.x, -4.5f, 0);

        }
        // if x position is > 11.5
        // X position = -11.5
        // else if Xposition < -11.5
        // X position = 11.5
        if (transform.position.x > 11.5f)
        {
            transform.position = new Vector3(-11.5f, transform.position.y, 0);

        }
        else if (transform.position.x < -11.5f)
        {
            transform.position = new Vector3(11.5f, transform.position.y, 0);
        }

    }

    void FireLaser() {
        _nextFire = Time.time + _fireRate;

        // calculate 0.8 units vertically from the player
        Vector3 laserPos = transform.position + new Vector3(0, 0.8f, 0);


        // Quaternion.identity = default rotation (0,0,0).
        Instantiate(_laserPrefab, laserPos, Quaternion.identity);
    }

        
    }

