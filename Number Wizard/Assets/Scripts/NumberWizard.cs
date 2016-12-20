using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour
{
	// Global variables
	int max = 1000, min = 1, count = 0, guess = 500;
	
	// Use this for initialization
	void Start ()
	{  
		print ("Welcome to the Number Wizard!\nPick a number in your head. (" + min + "-" + max + ")");
		print ("But don't tell me!\nI'm going to try to guess your secret!");
		CalculateAndGuess (guess);
	}
	
	// Update is called once per frame
	void Update ()
	{ 
		
		if (Input.GetKeyDown (KeyCode.Return)) {
			print ("Your number is " + guess + "\nIt took me " + count + " guesses.");
		} 
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			min = guess;
			guess = Mathf.CeilToInt (((max - min) / 2) + min);
			count++;
			CalculateAndGuess (guess);
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			max = guess;
			guess = Mathf.CeilToInt ((guess + min) / 2);
			count++;
			CalculateAndGuess (guess);
		}
		
	}
	void CalculateAndGuess (int guess)
	{
		print ("This is min: " + min + "\nAnd this is max: " + max);
		print ("Press the key that is correct in regards to your number.\n" +
			"(Up Arrow):      My number is HIGHER than " + guess);
		print ("(Enter):            My number    EQUALS " + guess + "\n" +
			"(Down Arrow):  My number is LOWER than " + guess);
	
	}
}
