using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SezerAge : MonoBehaviour
{
    // Defining the method that shows "currentAge" as a parameter
    void IncreaseSezerAge(int currentAge)
    {
        // Increase Sezers age by 1. (1 year passes).
        currentAge ++;

        // Debug.Log helps deliver data or a message to Unity's game engine, so it can execute the age change.
        Debug.Log("Sezers age after a year: " + currentAge);
    }

    // Start runs the game once, when the game is ran.
    void Start()
    {
        // Method for increasing "SezerAge", when current age is = "20".
        IncreaseSezerAge(20);
    }
}