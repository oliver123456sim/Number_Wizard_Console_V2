using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour {

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    [SerializeField] TextMeshProUGUI forsøgText;

    int guess;
    int forsøg;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        forsøg = forsøg + 1;
        guess = (max + min) / 2;
        guessText.text = guess.ToString();
        forsøgText.text = forsøg.ToString();
        max = max + 1;
    }

    public void OnPressHigher()
    {
        min = guess;
        NextGuess();
        forsøg = forsøg + 1;
    }

    public void OnPressLower()
    {
        max = guess;
        NextGuess();
        forsøg = forsøg + 1;
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        guessText.text = guess.ToString();
        forsøgText.text = forsøg.ToString();
    }
}
