using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max, min;
    [SerializeField] TextMeshProUGUI guessText;

    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        guess = (min + max) / 2;
        guessText.text = guess.ToString();
    }

    public void onPressHigher() //guessed number is higher
    {
        min = guess;
        NextGuess();
    }

    public void onPressLower()
    {
        max = guess;
        NextGuess();
    }

    void NextGuess()
    {
        guess = (min + max) / 2;
        guessText.text = guess.ToString();
    }
}
