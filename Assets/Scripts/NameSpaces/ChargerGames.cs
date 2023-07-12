using UnityEngine;

namespace ChargerGames
{

    public class Utilities
    {
        public static void PrintCharger()
        {
            Debug.Log("Charger Games");
        }
    }


    // Nested namespace
    namespace UI
    {
        public class UIStuff
        {
            public static void DoUI()
            {
                Debug.Log("Do UI()");
            }
        }
    }
}
