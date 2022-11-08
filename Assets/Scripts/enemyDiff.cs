using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDiff : MonoBehaviour
{
    float timer = 0f;
    float dTimer = 0f;

    public float sinToDoub;
    public float doubToSin;

    public GameObject singleSpawn;
    public GameObject doubleSpawn;

    private void Start()
    {
        doubleSpawn.SetActive(false);
        StartCoroutine(checkTimer());
    }

    IEnumerator checkTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            timer++;
            //Debug.Log(timer);
            checkEnemyDiff();

        }
    }

    void checkEnemyDiff()
    {
        if (timer > sinToDoub)
        {
            singleSpawn.SetActive(false);
            doubleSpawn.SetActive(true);
            dTimer++;
            if (dTimer > doubToSin)
            {
                singleSpawn.SetActive(true);                
                doubleSpawn.SetActive(false);
                timer = 0f;
                dTimer = 0f;
            }

        }

    }
}
