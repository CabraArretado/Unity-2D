using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int max = 1000;
        int min = 1;
        int guess = 500;

        Debug.Log("Welcome to Number Wizard, yo");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than " + max);
        Debug.Log("Push Up = Higher, Push Down = Lower, Backspace = Correct Number");
    }

    // Update is called once per frame
    void Update()
    {
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            Debug.Log("Up Arrow key was pressed.");
        }

        //Detect when the down arrow key is pressed down
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            Debug.Log("Down Arrow key was pressed.");
        }

        //Detect when the return key is pressed down
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("You hit enter.");
        }
        
    }
}
