using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	
	int max;
	int min;
	int guess;
	
	public Text text2;
	public Text text;
	public int maxGuessesAllowed;
	
	// Use this for initialization
	void Start () {
		StartGame ();
	}
	
	public void GuessHigher(){
		min = guess+1;
		if (min > max){
			min--;
		}
		NextGuess ();
	}
	
	public void GuessLower(){
		max = guess-1;
		if (max < min){
			max++;
		}
		NextGuess ();
	}
	
	void NextGuess (){
		Debug.Log (min + " " + max);
		guess = Random.Range(min,max);
		
		if (min != max){
			maxGuessesAllowed--;
		}
		
		if (maxGuessesAllowed < 0){
			Application.LoadLevel ("Win");
		}
		else{
			text2.text = "I have " + maxGuessesAllowed.ToString() + " guesses left.";
			text.text = guess.ToString();
		}
	
	
	}
	
	void StartGame() {
		max = 1000;
		min = 1;
		NextGuess();		
	}
}
