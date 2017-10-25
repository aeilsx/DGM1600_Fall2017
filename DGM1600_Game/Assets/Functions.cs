using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Funtions package code that can return a value and can be referenced and called upon later in the code.
//below are examples of functions with parameters and with returns. They can be used as a kind of bookmark
//and you won't have to type out the same code over and over also you don't have to get confused with 
//varaibles in another piece of code if you do it right.

public class Functions : MonoBehaviour {

	public void DoStuff(){
		print("I'm doing stuff...");
		int result = AddNumbers(5,11);
		print(result);
	}

	void Start(){
		DoStuff();

	}





	public int AddNumbers(int num1, int num2){
		
		int result = num1 + num2;
		
		return result;
	}





	public void RowBoats(){
		print("All the rowboats, in the paintings.");
		string boats = "They keep trying to row away.";
		print(boats);

		return boats;
	}

	void Start(){
		RowBoats();

	}




	public int SubtractNumbers(int num1, int num2){

		int result = num1 - num2;
		
		return result;
	}




	void DoMath(){
		 result = valueOne + valueTwo;
		 print(valueOne + "+" + valueTwo + "=" + result);

		 result = valueThree - valueFour;
		 print(valueThree + "-" + valueFour + "=" + result);

		 result = valueFive / valueSix;
		 print(valueFive + "/" + valueSix + "=" + result);

		 result = valueSeven * valueEight;
		 print(valueSeven + "*" + valueEight + "=" + result);
	}





	void Countdown(){
		public int time;

		while(time > 0){
			time --;
			print(time);
		}
	}




	
	public void TheThing(){
		print("Julie! Do the thing!!!");
		int result = Rowboats();
		print(result);
	}

	void Start(){
		TheThing();

	}
	


	void HogwartsLetter(){
		if(magic){
			print("Wizard");
		}
		else if(!magic){
			print("Squib");
		}
		else{
			print("Muggle");
		}

	}

	void Start(){
		HogwartsLetter();
	}




	void Multiplication(int num1, int num2){

		int result = num1 * num2;
		
		return result;
	}





	void Division(int num1, int num2){

		int result = num1 / num2;
		
		return result;
	}

}
