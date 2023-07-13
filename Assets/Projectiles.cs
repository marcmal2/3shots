using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

    public GameObject prefabToSpawn;
    public float pauseTime = 1f;
    void Start()
    {
        StartCoroutine(SpawnObjectsRoutine()); 
    }

    IEnumerator SpawnObjectsRoutine(){
        while(true){ 
            Vector3 randomSpawnPos = new Vector3(Random.Range(-7f,7f),Random.Range(6f,6f),0);
            GameObject newObject = Instantiate(prefabToSpawn,randomSpawnPos,Quaternion.identity);
            Destroy(newObject,10);
            yield return new WaitForSeconds(pauseTime);
        }
        yield return null;
    }

}
