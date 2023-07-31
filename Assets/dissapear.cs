using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dissappear : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D other) {
     if(other.gameObject.CompareTag("Bullet")){
        Destroy(this.gameObject);
        GameObject creatureObject = GameObject.Find("Creature");
      Creature character = creatureObject.GetComponent<Creature>();
        character.AddAmmo();
     }   
    }
}
