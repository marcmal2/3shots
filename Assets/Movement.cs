using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Player player;
    private float moveSpeed;
    private Vector3 directionToPlayer;
    private Vector3 localScale;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = FindObjectOfType(typeof(Player)) as Player;
        moveSpeed = 2.5f;
        localScale = transform.localScale;
    }

    // Update is called once per frame
    private void FixedUpdate() {
        MoveEnemy();
    }

    private void MoveEnemy() {
        directionToPlayer = (player.transform.position - transform.position).normalized;
        rb.velocity = new Vector2(directionToPlayer.x, directionToPlayer.y) * moveSpeed;
    }

    private void LateUpdate() {
        if (rb.velocity.x > 0)
        {
            transform.localScale = new  Vector3(localScale.x, localScale.y, localScale.z);
        
        }
        else if (rb.velocity.x < 0)
        {
           transform.localScale = new  Vector3(-localScale.x, localScale.y, localScale.z); 
        }
    }

}
