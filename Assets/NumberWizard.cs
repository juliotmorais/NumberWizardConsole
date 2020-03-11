using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    int max;
    int min;
    int guess;


    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return)){
            Debug.Log("I guessed your number!");
            Debug.Log("Restarting game!");
            StartGame();

        }
        
    }
    
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Pick a number! Keep it a secret!");
        Debug.Log("The highest number you can choose is " + max);
        Debug.Log("The lowest number you can choose is " + min);
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Push up = higher, Push Down = lower, Enter = Correct");
        max += 1;
    }

    void NextGuess()
    {
        max = guess;
        guess = (max + min) / 2;
        Debug.Log("Higher or lower than... "+guess);
    }
}
