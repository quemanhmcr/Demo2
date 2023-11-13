using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Subject 
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            NotifyObsever(Action.A);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            NotifyObsever(Action.D);
        }
    }
}
