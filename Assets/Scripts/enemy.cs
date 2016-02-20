using UnityEngine;
using System.Collections;

/*
Hank: For some projectile stuff... probably a misnomer on file name
*/

public class enemy : MonoBehaviour {
    //Start of scripts creation. Used to instantiate variables in our case.
    void Start() {
    }
    
    //Called every frame
    void FixedUpdate() {
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        Destroy(other.gameObject);
    }


}

