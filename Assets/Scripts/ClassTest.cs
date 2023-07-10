using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Instance/object of the Car class
        Car myCar = new Car(); // create new instance/object of a class
    
        myCar.speed = 10.5f;
        myCar.color = "Red";
        myCar.highestSpeed = 20;

        myCar.CarSpeed(); // Call function from the Car class

        // Another instance/object of a Car class
        Car suzuki = new Car();

        suzuki.speed = 15f;
        suzuki.color = "Geen";
        suzuki.highestSpeed = 30;

        suzuki.CarSpeed(); // Call function from the Car class

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
