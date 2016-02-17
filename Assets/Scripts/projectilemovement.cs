using UnityEngine;
using System.Collections;

/*
Carson:
Basic WASD absolute/static movement.
*/

public class projectilemovement : MonoBehaviour {
    public Rigidbody2D rocket;

    //Start of scripts creation. Used to instantiate variables in our case.
    void Start() {
    }
    
    //Called every frame
    void FixedUpdate() {
        

        //Add velocity to the object based on this velocity.
        //GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, Speed);
    }
}

