using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Spawngems : MonoBehaviour
{

    public GameObject gem;
    public float pauseTime = 2f;
    public Text p;
    public int Roundtime = 0;

    void Start()
    {
        StartCoroutine(SpawnGemsRoutine()); 
    }


    IEnumerator SpawnGemsRoutine(){
        while(true){ 
            Vector3 randomSpawnPos = new Vector3(Random.Range(-14f,14f),Random.Range(14f,14f),0);
            GameObject gems = Instantiate(gem,randomSpawnPos,Quaternion.identity);
            Roundtime++;
            p.text = Roundtime.ToString();
            pauseTime = pauseTime - 0.03f;
            if(pauseTime < 0.00f){
                pauseTime = 0.05f;
            }
            yield return new WaitForSeconds(pauseTime);
        }
        yield return null;
    }
}
