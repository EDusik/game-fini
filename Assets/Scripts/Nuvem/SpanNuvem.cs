using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpanNuvem : MonoBehaviour {

    public GameObject nuvem;
    public int nuvemCount;
    public Vector3 spawnValues;
    public float spawnWait;
    // Use this for initialization
    void Start () {
        StartCoroutine(SpawnNuvem());
    }

    IEnumerator SpawnNuvem() {

        for (int i = 0; i < nuvemCount; i++) {
            GameObject n = nuvem;
            Vector3 spawnPosition = new Vector3(-12.0f, Random.Range(9.5f, 5.0f), 7);
            Quaternion spawnRotation = Quaternion.identity;
            NewMethod(n, spawnPosition, spawnRotation);
            yield return new WaitForSeconds(spawnWait);
        }
    }

    private static void NewMethod(GameObject n, Vector3 spawnPosition, Quaternion spawnRotation) {
        Instantiate(n, spawnPosition, spawnRotation);
    }

    // Update is called once per frame
    void Update () {

    }
}