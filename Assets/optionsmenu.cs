using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class optionsmenu : MonoBehaviour
{
    public void OpenOptionsMenu(){
        GetComponent<Canvas>().enabled = true;
    }

    public void CloseOptionsMenu(){
        GetComponent<Canvas>().enabled = false;
    }
}
