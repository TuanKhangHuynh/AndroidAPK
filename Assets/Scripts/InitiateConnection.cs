using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitiateConnection : MonoBehaviour
{
    private int tick;
    public bool connection;
    // Start is called before the first frame update
    void Start()
    {
    }
    void awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (tick <= 5) {
            if (connection == false)
            {
                Client.instance.ConnectToServer();
                connection = true;
            }
            
        }
        if (tick < 5)
        {
            tick += tick;
        }
    }
}
