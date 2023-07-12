using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoRoutineTest : MonoBehaviour
{

    GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
       //  StartCoroutine(Test());
        StartCoroutine("Test"); // the most recommended way
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // CoRoutine
    IEnumerator Test()
    {
        print(" CoRoutine Starts");

        // yield must be in every CoRoutine
        yield return new WaitForSeconds(2f);

        GetComponent<Renderer>().material.color = Color.red;

        yield return new WaitForSeconds(2f);

        GetComponent<Renderer>().material.color = Color.green;

        print(" CoRoutine Ends");
    }

}
