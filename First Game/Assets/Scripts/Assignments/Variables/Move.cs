using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float speed;
    public float turnSpeed;
    public float verticalInput;
    public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical"); //GetKey(KeyCode "Space") y axis
        horizontalInput = Input.GetAxis("Horizontal"); //left and right

        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);
        // (x, y, x)
    }
}

    //Detect collision with another object
      /* void OnCollisionEnter(Collision other) {

        if (other.gameObject.CompareTag("floor")) //primary
        {
            Debug.Log("Colliding with floor");
        }

        else if (other.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("colliding with Obstacle"); //secondary
        }
        else //Default
        {
            Debug.Log("...");
        }
        
    }
        


    void OnTriggerEnter(Collider other)
{
    Debug.Log("you have entered the trigger!");
}

} */