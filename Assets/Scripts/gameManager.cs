using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    private static gameManager _instance;

    public static gameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject go = new GameObject("GameManager");
                go.AddComponent<gameManager>();
            }
            return _instance;
        }
    }

    public bool yellowRd;
    public bool isAlive;
    public bool isPause;

    void Awake()
    {
        _instance = this;
    }

}
