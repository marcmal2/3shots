using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletdissappear : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D other) {
     if(other.gameObject.CompareTag("Zombie")){
        Destroy(this.gameObject);
     }   
    }
}
