using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour

{
    public float speed = 5;

    public GameObject target;

    Rigidbody2D rb;

    void Awake(){
        rb = GetComponent<Rigidbody2D>();
        Destroy(this.gameObject,20);
    }

    void Start()
    {
        //GetComponent<Rigidbody2D>().velocity = new Vector2(0,1);
       //transform.rotation = Quaternion.LookRotation(transform.forward, target.transform.position - transform.position);
    }

    // Update is called once per frame
    void Update()
    {
       //transform.rotation = Quaternion.LookRotation(transform.forward, Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position);
       //rb.velocity = transform.up * speed;
    }

    public void Launch(Vector3 position){
        transform.rotation = Quaternion.LookRotation(transform.forward, position - transform.position);
        rb.velocity = transform.up * speed;
    }
}
