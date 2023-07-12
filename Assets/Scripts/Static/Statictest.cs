using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statictest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // with classic vars every instance of 
        // a class has it's own value for the noOfBullets
        // with classic public noOfBullets variable
        // Bullets bullet1 = new Bullets();
        // bullet1.noOfBullets = 10;
        // print(bullet1.noOfBullets);

        // Bullets bullet2 = new Bullets();
        // bullet2.noOfBullets = 20;
        // print(bullet2.noOfBullets);


        // with static noOfBullets variable 
        // for now every instances hav the same
        // single value for noOfBullets variable
        // Bullets bullet1 = new Bullets();
        // Bullets.noOfBullets = 10;

        // Bullets bullet2 = new Bullets();
        // Bullets.noOfBullets = 20;

        // print(Bullets.noOfBullets); // will be 20

        // with Constructor
        Bullets bullet1 = new Bullets();

        Bullets bullet2 = new Bullets();
        
        Bullets bullet3 = new Bullets();

        // will be displayed in console how many
        // instances of a Bullets class we have
        print(Bullets.noOfBullets); // in our case it's 3
        

        // Simply calling static function
        Bullets.ShowBullets();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
} // StaticTest ends

public class Bullets
{
    // public int noOfBullets;

    // if it's static it means that for entire class
    // we have only one instance of noOfBullets
    // and it doesn't matter how many instances of this class
    // we have
    // public static int noOfBullets;
    
    public static int noOfBullets = 0;

    // constructor
    public Bullets()
    {
        noOfBullets++;
    }

    // Static Functions cannot access to
    // non static variables
    public static void ShowBullets()
    {
        Debug.Log("NO of Bullets " + noOfBullets);
    }

}