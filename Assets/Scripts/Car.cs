using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car
{

    // atributes of the class
    public float speed;
    public string color;
    public int highestSpeed;

    // behaviours of the class
    void Move()
    {
        Debug.Log("Moving");
    }

    void ApplyBrake()
    {
        Debug.Log("Applying Brake");
    }

    public void CarSpeed()
    {
        Debug.Log(speed);
    }

}
