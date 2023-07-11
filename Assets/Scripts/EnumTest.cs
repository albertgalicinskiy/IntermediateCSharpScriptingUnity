using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumTest : MonoBehaviour
{

    // public enum GameState { Ready, Playing, Pause, GameOver };
    public enum GameState { Ready = 2, Playing = 4, Pause = 6, GameOver = 3 };

    public GameState state;

    // Start is called before the first frame update
    void Start()
    {
        // for this variable we can only assign valuse from 8 line
        state = GameState.Ready; 
    }

    // Update is called once per frame
    void Update()
    {
        // switch(state)
        // {
        //     case GameState.Ready:
        //         print("You Are Ready");
        //         break;
        //     case GameState.Playing:
        //         print("Game is Playing");
        //         break;
        //     case GameState.Pause:
        //         print("Pause");
        //         break;
        //     case GameState.GameOver:
        //         print("Game is Over");
        //         break;           
        // }

        switch(state)
        {
            case GameState.Ready:
                //print(GameState.Ready); // Ready will be printed in the console
                print((int)GameState.Ready); // 0 will be printed in the console
                break;
            case GameState.Playing:
                print((int)GameState.Playing); // 1 will be printed in the console
                break;
            case GameState.Pause:
                print((int)GameState.Pause); // 2 will be printed in the console
                break;
            case GameState.GameOver:
                print((int)GameState.GameOver); // 3 will be printed in the console
                break;           
        }
    }
}
