using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float vel;
    int num;
    bool MovRight;
    bool MovLeft;
    void Start()
    {
        vel = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(MovRight==true)
        {
            transform.Translate(1 * Time.deltaTime, 0 * Time.deltaTime * vel, 0);
        }
        else
        {
            transform.Translate(1 * Time.deltaTime, 0 * Time.deltaTime * vel, 0);
        }
        for (int i = 0; i <= 10; i++)
        {
            vel++;
        }

        while (vel < 5)
        {
            transform.Translate(1 * Time.deltaTime, 2 * Time.deltaTime * vel, 0);
        }
        
    }
}
