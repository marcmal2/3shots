using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class gem : MonoBehaviour
{
    public Text text;

    int counter = 0;

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Gem"){
            GetComponent<AudioSource>().Play();
            counter+=1;
           text.text = counter.ToString();
        }
    }

}
