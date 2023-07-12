using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class AttributesTest : MonoBehaviour
{

    // will be accessible only in Inspector
    // not in other scripts
    [SerializeField] private int speed;

    // will be accessible only in other scripts 
    // not in Inspector
    [HideInInspector] public int speed2;

    [Range(0, 20)] public int speed3;

    Rigidbody rb; // Rigidbody is not attached to the Cube


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Rigidbody is not attached to the Cube
    }

    // Update is called once per frame
    void Update()
    {
        // move the object
        transform.Translate(speed3 * Time.deltaTime, 0, 0);

        rb.isKinematic = false; // Rigidbody is not attached to the Cube
    }
}
