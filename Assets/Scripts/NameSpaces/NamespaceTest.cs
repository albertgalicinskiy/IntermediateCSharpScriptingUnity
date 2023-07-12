using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ChargerGames;
using ChargerGames.UI; // using nested namespace

public class NamespaceTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // without using namespace
        ChargerGames.Utilities.PrintCharger();
        
        // with using namespace
        Utilities.PrintCharger();

        // using nested namespace
        UIStuff.DoUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
