using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] // with this config we can set public variable with entire Class Car object in the another script and 
// set values for the Class Car attributes in the Unity Inspector without writing code

public class Car
{

    // atributes of the class
    public float speed;
    public string color;
    public int highestSpeed;

    public Car() // not need to set any returns type for this Constructor function
    {
        Debug.Log("Car() Called"); // we will know that our constructor is called 
    }

    // Constructors public Car(...)
    public Car(float speed)
    {
        this.speed = speed; // we assign value of speed to speed variable
        Debug.Log("Car(float) Called");
        Debug.Log(speed);
    }

    public Car(float speed, string color)
    {
        this.speed = speed;
        this.color = color;
        Debug.Log("Car(float, string) Called");
        Debug.Log("Speed is " + speed + " and the Color is " + color );

    }

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

    public void PrintCarDetails()
    {
        Debug.Log("Speed = " + speed);
        Debug.Log("Color = " + color);
        Debug.Log("HighestSpeed = " + highestSpeed);
    }
}
