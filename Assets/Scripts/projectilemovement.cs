﻿using UnityEngine;
using System.Collections;

/*
Hank: For some projectile stuff... probably a misnomer on file name
*/

public class projectilemovement : MonoBehaviour {
    public Rigidbody2D rocket;
    // 100 as a number mathes the max distance traveled fairly well right now. Can be tuned
    int lifetime = 100;

    //Start of scripts creation. Used to instantiate variables in our case.
    void Start() {
    }
    
    //Called every frame
    void FixedUpdate() {
        lifetime--;
        if (lifetime <= 0) {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        Destroy(other.gameObject);
    }
}

