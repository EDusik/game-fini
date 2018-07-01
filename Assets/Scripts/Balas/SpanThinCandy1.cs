using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpanThinCandy1 : MonoBehaviour {

    public GameObject thinCandy1;
    public int thinCandyCount;
    public Vector3 spawnValues;
    public float spawnWait;
    bool start = false;

    void Start () {        
        StartCoroutine(SpawnCandy());      
    }

    IEnumerator SpawnCandy() {
      
        for (int i = 0; i < thinCandyCount; i++) {
            GameObject tc = thinCandy1;
            Vector3 spawnPosition = new Vector3(Random.Range(-5.75f, 5.75f), 20);
            Quaternion spawnRotation = Quaternion.identity;
            NewMethod(tc, spawnPosition, spawnRotation);
            yield return new WaitForSeconds(spawnWait);            
        }
     
    }

    private static void NewMethod(GameObject tc, Vector3 spawnPosition, Quaternion spawnRotation) {
        Instantiate(tc, spawnPosition, spawnRotation);
    }

    void Update () {
      //  transform.position -= new Vector3(0, speed, 0) * Time.deltaTime;
    }
}
