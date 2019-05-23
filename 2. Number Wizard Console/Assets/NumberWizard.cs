using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max, min, guess;

    // Start is called before the first frame update
    void Start()
    {
        startGame();
    }

    void startGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to number wizard!");
        Debug.Log("Pick a number");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
        Debug.Log("Current guess is:" + guess + "\n Push UP say your number is higher, Down say lower, Enter say correct");
        max += 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I am a genius!");
            startGame();
        }
    }

    void NextGuess()
    {
        Debug.Log("New range is: " + min + "~" + max);
        guess = (max + min) / 2;
        Debug.Log("Current guess is: " + guess);
    }
}
