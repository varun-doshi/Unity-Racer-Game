using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public uiManager uiM;

    public float step;
    private Rigidbody2D rb;
    Vector2 target;
    public float maxPos;
    public float carSpeed;

    private void Awake()
    {
        gameManager.Instance.isAlive = false;
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = transform.position;
    }

    private void Update()
    {
        //target.x += Input.GetAxis("Horizontal") * step * Time.deltaTime;
        target = transform.position;
        target.x = Mathf.Clamp(target.x, -maxPos, maxPos);
        transform.position = target;
    }

    public void goLeft()
    {
        rb.velocity = new Vector2(-carSpeed, 0);
    }

    public void goRight()
    {
        rb.velocity = new Vector2(carSpeed, 0);
    }

    public void goZer0()
    {
        rb.velocity = new Vector2(0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "enemy" )
        {
            //Debug.Log("Touch");
            gameManager.Instance.isAlive = true;
            uiM.gameOverScreen();
            Destroy(gameObject);
        }
        else if(collision.tag=="danger road")
        {
            //Debug.Log("Wall");
            gameManager.Instance.isAlive = true;
            uiM.gameOverScreen();
            Destroy(gameObject);
        }
    }
    


}
