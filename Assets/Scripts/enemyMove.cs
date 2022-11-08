using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{

    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position -= new Vector3(0, speed * Time.deltaTime,0);

        if (transform.position.y < -10f)
        {
            Destroy(gameObject);
        }
    }
}
