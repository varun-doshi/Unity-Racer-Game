using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawnner : MonoBehaviour
{
    public GameObject[] enemySprite;
    public Vector3[] spawnLocs;
    public float spawnDiff;
    Vector3 enemyPos;


    private void OnEnable()
    {
        StartCoroutine(spawnActivate());
    }



    void spawn()
    {
        int carNo = Random.Range(0, enemySprite.Length);
        int i = Random.Range(0, spawnLocs.Length);
        enemyPos = new Vector3(spawnLocs[i].x, spawnLocs[i].y, spawnLocs[i].z);
        //Debug.Log("Yo");
        
        Instantiate(enemySprite[carNo], enemyPos, transform.rotation);

    }

    IEnumerator spawnActivate()
    {
        
        while (true)
        {
            yield return new WaitForSeconds(spawnDiff);
            spawn();
        }
    }
}
