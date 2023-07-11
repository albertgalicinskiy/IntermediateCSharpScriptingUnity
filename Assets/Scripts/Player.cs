using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        Score score = new Score(); // instance/object of the Score class

        score.Point = 4;
        print(score.Point); // won't be in console less than 5

        score.Point = 7;
        print(score.Point); // will be in console greater than 5 and less than 10

        score.Lives = 5;
        print(score.Lives); // auto property will be used
 
        // score.Lives2 = 6; // error will occur because this auto-property is read only (get)s


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
