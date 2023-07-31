using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Creature : MonoBehaviour
{
    [Header("Config")]
    public int healthPoints = 10;
    public float speed = 3.0f;
    public string creatureName = "Meepis";
    public int ammo = 3;
    public Text text;

    [Header("Projectiles")]
    public GameObject ProjectilePrefab;

    [Header("References")]

    Rigidbody2D rb;
    SpriteRenderer sr;
    AnimationStateChanger animationStateChanger;
    void Awake(){
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        animationStateChanger = GetComponent<AnimationStateChanger>();
        text.text = ammo.ToString();
    }

    public void Move(Vector3 direction){
        
        rb.velocity = direction*speed;

        if(direction == Vector3.zero){
            animationStateChanger.ChangeAnimationState("Idle");
        }else{
            animationStateChanger.ChangeAnimationState("Walk",1);

        }

        if(Mathf.Abs(rb.velocity.x) > 0){
            sr.flipX = rb.velocity.x < 0;
        }
    }

     public void LaunchProjectile(Vector3 position){
        if (ammo > 0)
        {
            GameObject newProjectile = Instantiate(ProjectilePrefab,transform.position,Quaternion.identity);
            newProjectile.GetComponent<Projectiles>().Launch(Camera.main.ScreenToWorldPoint(Input.mousePosition));
            ammo--;
            text.text = ammo.ToString();
        }
    }

    public void AddAmmo()
    {
        ammo++;
        text.text = ammo.ToString();
    }
}

