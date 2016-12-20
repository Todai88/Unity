using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour
{
	// Global variables
	int max, min, count, guess;
	bool flag;
	// Use this for initialization
	void Start ()
	{  
		StartingGame ();
	}
	
	// Update is called once per frame
	void Update ()
	{ 
		
		if (flag && (Input.GetKeyDown (KeyCode.Return))) {
			Input.ResetInputAxes ();
			StartingGame (); 
		}
		
		if (!flag && (Input.GetKeyDown (KeyCode.Return))) {
			print ("Your number is " + guess + "\nIt took me " + count + " guesses.");
			print ("Play again?\nPress 'y' to restart!");
			flag = true;  
		}
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			min = guess; 
			NextGuess ();
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			max = guess; 
			NextGuess (); 
		}
		
	}
	/*
	(Re)Starts the game by instantiating the variables and printing the welcome text.
	*/
	void StartingGame ()
	{
		
		max = 1000;
		min = 1;
		count = 1;
		guess = 500;
		flag = false;
		
		print ("============= STARTING GAME ==============");
		print ("Welcome to the Number Wizard!\nPick a number in your head. (" + min + "-" + max + ")");
		print ("But don't tell me!\nI'm going to try to guess your secret!");
		max++;
		printInfo ();
	}
	
	/*
	NextGuess:
	Returns nothing, calculates the next guess and adds to count then prints the next question.
	*/
	void NextGuess ()
	{
		guess = Mathf.CeilToInt (((max + min) / 2));
		count++;
		printInfo ();
	}
	
	/*
	Prints the next question.
	*/
	
	void printInfo ()
	{
	
		print ("Press the key that is correct in regards to your number.\n" +
			"(Up Arrow):      My number is HIGHER than " + guess);
		print ("(Enter):            My number    EQUALS " + guess + "\n" +
			"(Down Arrow):  My number is LOWER than " + guess);
	
	}
}
