using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float playerSpeed = 4f;

 

    void FixedUpdate()
    {
        Vector2 targetVelocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        GetComponent<Rigidbody2D>().velocity = targetVelocity * playerSpeed;
    }

    public void South_Colider()
    {       
            transform.position += Vector3.up * 0.5f;                
    }

    public void North_Colider()
    {
        transform.position += Vector3.down * 0.5f;
    }

    public void East_Colider()
    {
        transform.position += Vector3.right * -0.5f;
    }

    public void West_Colider()
    {
        transform.position += Vector3.left * -0.5f;
    }

}

