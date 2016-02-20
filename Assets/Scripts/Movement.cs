using UnityEngine;
using System.Collections;

/*
Carson:
Basic WASD absolute/static movement.
*/

public class Movement : MonoBehaviour {
    public Rigidbody2D rocket;
    public float rspeed = 10000f;

    //Speed to move at
    public float Speed = 10;

    //Horizontal movement. 1 is right, -1 is left, 0 is no movement.
    private float movex;

    //Vertical movement. 1 is up, -1 is down, 0 is no movement.
    private float movey;
    
    //Start of scripts creation. Used to instantiate variables in our case.
    void Start() {
        movex = 0f;
        movey = 0f;
    }
    
    //Called every frame
    void FixedUpdate() {
        //Get the x and y movement
        movex = Input.GetAxis("Horizontal");
        movey = Input.GetAxis("Vertical");
        //Add velocity to the object based on this velocity.
        GetComponent<Rigidbody2D>().velocity = new Vector2(movex * Speed, movey * Speed);

        // Hank: temp shooting code
        if (Input.GetKey(KeyCode.Mouse0)) {
            Rigidbody2D rocketClone = (Rigidbody2D) Instantiate(rocket, transform.position, transform.rotation);
            // Note: 10000  works well with a 2.0 linear drag on the Rocket's Rigidbody - fast shot speed, and
            // it stops not too far away from the initial position
            rocketClone.AddForce(transform.up * 10000);
            Destroy(rocketClone, 5);
        }
    }

    /*##Exact Movement##, left/right/up/down, no diagnol
    void Update() {

        if (Input.GetKey(KeyCode.A))
            movex = -1;
        else if (Input.GetKey(KeyCode.D))
            movex = 1;
        else
            movex = 0;
        if (Input.GetKey(KeyCode.W))
            movey = 1;
        else
            movey = 0;
    }

    void FixedUpdate() {

        rigidbody2D.velocity = new Vector2(movex * Speed, movey * Speed);
    }
    */
}

