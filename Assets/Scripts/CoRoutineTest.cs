using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoRoutineTest : MonoBehaviour
{

    GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        // StartCoroutine(Test());
        // StartCoroutine("Test"); // the most recommended way

        // Test2();
        // // only after finishing Test2()
        // for (int i = 0; i < 6; i++ )
        // {
        //     print("Start()");
        // }


        // will be running in parallel
        // CoRoutine without parameters
        // StartCoroutine("Test3");

        // CoRoutine with parameters
        StartCoroutine("Test3", 8);

        // not waiting StartCoroutine("Test3");
        // for (int i = 0; i < 6; i++ )
        // {
        //     print("Start()");
        // }

        // StopCoroutine("Test3");
    }


    // CoRoutines run in parallel to your current code
    // CoRoutine
    IEnumerator Test()
    {
        print(" CoRoutine Starts");

        // yield must be in every CoRoutine
        yield return new WaitForSeconds(2f);

        GetComponent<Renderer>().material.color = Color.red;

        yield return new WaitForSeconds(2f);

        GetComponent<Renderer>().material.color = Color.green;

        // we have to wait for current frame to be finished and new frame to be started
        yield return null; 

        print(" CoRoutine Ends");
    }

    void Test2()
    {
        for (int i = 0; i < 6; i++ )
        {
            print("Test2()");
        }
    }

    IEnumerator Test3(int times)
    {
        for (int i = 0; i < times; i++ )
        {
            print("Test3()");

            yield return null;
        }
    }

}
