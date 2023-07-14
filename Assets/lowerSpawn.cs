using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerSpawn : MonoBehaviour
{

    public GameObject gem;
    public float pauseTime = 1f;
    void Start()
    {
        StartCoroutine(SpawnGemsRoutine()); 
    }


    IEnumerator SpawnGemsRoutine(){
        while(true){ 
            Vector3 randomSpawnPos = new Vector3(Random.Range(-7f,7f),Random.Range(-6f,-6f),0);
            GameObject gems = Instantiate(gem,randomSpawnPos,Quaternion.identity);
            Destroy(gems,10); 
            yield return new WaitForSeconds(pauseTime);
        }
        yield return null;
    }
}
