using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class track2Move : MonoBehaviour
{
    public float speed;
     float rdTimer;
    float endTimer;
    Vector3 target1 = new Vector3(0, 0, 0);
    Vector3 target2 = new Vector3(0, -10f, 0);

    private void Start()
    {
        StartCoroutine(roadTimer());
    }

    private void Update()
    {
        activateRd2();
        /*if (gameManager.Instance.yellowRd)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }*/
        
    }


    IEnumerator roadTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            rdTimer++;
            if (rdTimer > 10)
            {
                endTimer++;
            }
            //Debug.Log(rdTimer);

        }
        
    }

    void activateRd2()
    {
        if (rdTimer > 10)
        {
            gameManager.Instance.yellowRd = true;
        }
        if (gameManager.Instance.yellowRd)
        {
            transform.position = Vector3.MoveTowards(transform.position, target1, speed * Time.deltaTime);
            
        }
        if (endTimer > 15)
        {
            //Debug.Log("YO");
            rdTimer = 0;
            gameManager.Instance.yellowRd = false;
            transform.position = Vector3.MoveTowards(transform.position, target2, speed * Time.deltaTime);
        }
    }
}
