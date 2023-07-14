using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{   
    public Creature playerCreature;

    Vector3 moveDir = Vector3.zero;
    void FixedUpdate(){
        HandleMovement();
    }

void Update(){
        if(Input.GetMouseButtonDown(0)){
            playerCreature.LaunchProjectile(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }
    }

    void HandleMovement(){
        moveDir = Vector3.zero;

        //GetKey() returns true if the button is pressed or held
        if(Input.GetKey(KeyCode.W)){
            moveDir.y += 1;
        }
        if(Input.GetKey(KeyCode.S)){
            moveDir.y -= 1;
        }
        if(Input.GetKey(KeyCode.A)){
            moveDir.x -= 1;
        }
        if(Input.GetKey(KeyCode.D)){
            moveDir.x += 1;
        }
        playerCreature.Move(moveDir);
    }
}