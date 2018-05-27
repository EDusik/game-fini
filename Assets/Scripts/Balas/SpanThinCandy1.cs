using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpanThinCandy1 : MonoBehaviour {

    public GameObject thinCandy1;
    public int thinCandyCount;
    public Vector3 spawnValues;
    public float spawnWait;

    // Use this for initialization
    void Start () {
        StartCoroutine(SpawnCandy());
    }

    IEnumerator SpawnCandy() {

        for (int i = 0; i < thinCandyCount; i++) {
            GameObject tc = thinCandy1;
            // Vector3 spawnPosition = new Vector3(-12.0f, Random.Range(9.5f, 5.0f), 7);
           // Vector3 spawnPosition = new Vector3(-12.0f, Random.Range(9.5f, 5.0f), 7);
            Vector3 spawnPosition = new Vector3(Random.Range(-8.0f, 7.0f), 13);


            Quaternion spawnRotation = Quaternion.identity;
            NewMethod(tc, spawnPosition, spawnRotation);
            yield return new WaitForSeconds(spawnWait);
        }
    }

    private static void NewMethod(GameObject tc, Vector3 spawnPosition, Quaternion spawnRotation) {
        Instantiate(tc, spawnPosition, spawnRotation);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
