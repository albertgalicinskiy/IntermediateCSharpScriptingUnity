using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score
{
    private int point;

    private int lives;

    private int lives2;

    public int Point
    {
        get
        {
            return point;
        }
        set
        {
            if (value > 5 && value < 10)
            {
                point = value;
            }
            PrintPoint();
        }
    }

    public int Lives { get; set; } // auto properties
    
    public int Lives2 { get; } // this property allow only get and we can't set any values to the variable



    void PrintPoint()
    {
        Debug.Log(point);
    }
}
