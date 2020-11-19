using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    int max;
    int min;
    int guess;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        // Console Greeting
        Debug.Log("Welcome to Number Wizard, mate. Chose a number and I gonna try to guess it!");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Backspace = Correct Number");
        Debug.Log("My guess first guess is: " + guess);
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("My guess is: " + guess);
        Debug.Log("Is that your number?");
        Debug.Log("Push Up = Higher, Push Down = Lower, Backspace = Correct Number");
    }



    // Update is called once per frame
    void Update()
    {
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed.");
            min = guess;
            NextGuess();
        }

        //Detect when the down arrow key is pressed down
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow key was pressed.");
            max = guess;
            NextGuess();
        }

        //Detect when the return key is pressed down
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Finally I got it! Your number was: " + guess);
        }
        
    }
}
