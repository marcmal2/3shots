using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    public float speed = 3;
    Rigidbody2D rb;
    SpriteRenderer sr;
    void Awake(){
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    public void Move(Vector3 direction){
        
        rb.velocity = direction*speed;
        if(Mathf.Abs(rb.velocity.x) > 0){
            sr.flipX = rb.velocity.x < 0;
        }
    }
}

