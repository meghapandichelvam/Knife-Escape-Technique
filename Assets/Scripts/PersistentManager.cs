using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentManager : MonoBehaviour
{
    private static PersistentManager _instance;
    public static PersistentManager Instance { get => _instance; set => _instance = value; }

    private void Awake()
    {
        if (_instance != null && _instance != this)
            Destroy(this.gameObject);
        else
            _instance = this;
        if (_instance != null && _instance != this)
            Destroy(this.gameObject);
        else
            _instance = this;


        DontDestroyOnLoad(gameObject);
    }
}
