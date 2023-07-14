using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    [Header("Config")]
    public int healthPoints = 10;
    public float speed = 3.0f;
    public string creatureName = "Meepis";

    [Header("Projectiles")]
    public GameObject ProjectilePrefab;

    [Header("References")]

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

     public void LaunchProjectile(Vector3 position){
        GameObject newProjectile = Instantiate(ProjectilePrefab,transform.position,Quaternion.identity);
        newProjectile.GetComponent<Projectiles>().Launch(Camera.main.ScreenToWorldPoint(Input.mousePosition));
    }
}

