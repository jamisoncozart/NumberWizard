using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to number wizard!");
        Debug.Log("Pick a number, don't tell me what it is...");
        Debug.Log("Highest number you can pick is: " + max);
        Debug.Log("Lowest number you can pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Push Up = higher, Push Down = Lower, Push 'Enter' = Correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("up arrow was pressed");
            min = guess;
            guess = (max + min) / 2;
            Debug.Log(guess);
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("down arrow was pressed");
            max = guess;
            guess = (max + min) / 2;
            Debug.Log(guess);
        }
        else if(Input.GetKeyDown(KeyCode.Return))
        {
            print("enter key was pressed");
        }
    }
}
