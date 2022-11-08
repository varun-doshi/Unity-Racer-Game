using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doubleSpawnner : MonoBehaviour
{
    private Vector3 pos1=new Vector3(0,7.5f,0);
    private Vector3 pos2 = new Vector3(1.78f, 7.5f, 0);
    private Vector3 pos3 = new Vector3(-1.78f, 7.5f, 0);

    public GameObject[] enemyPref;


    private void OnEnable()
    {
        StartCoroutine(doubSpawn());
    }

    void doubleSpawn()
    {
            int i = Random.Range(1, 4);
            if (i == 1)
            {
                int carNo1 = Random.Range(0, enemyPref.Length);
                int carNo2 = Random.Range(0, enemyPref.Length);
                Instantiate(enemyPref[carNo1], pos2, transform.rotation);
                Instantiate(enemyPref[carNo2], pos3, transform.rotation);
            }
            if (i == 2)
            {
                int carNo1 = Random.Range(0, enemyPref.Length);
                int carNo2 = Random.Range(0, enemyPref.Length);
                Instantiate(enemyPref[carNo2], pos1, transform.rotation);
                Instantiate(enemyPref[carNo1], pos3, transform.rotation);
            }
            if (i == 3)
            {
                int carNo1 = Random.Range(0, enemyPref.Length);
                int carNo2 = Random.Range(0, enemyPref.Length);
                Instantiate(enemyPref[carNo1], pos2, transform.rotation);
                Instantiate(enemyPref[carNo2], pos1, transform.rotation);
            }
        }

    IEnumerator doubSpawn()
    {
        while(true){
            yield return new WaitForSeconds(3f);
            doubleSpawn();
        }
    }

    }


