using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Logical Operators are used as comparison factors in loops. == is used to compare two pieces 
//of data and returns if they are true. && is for when you need this AND that to be returned
//as true or false. || is for if one data OR the other is true it will return true. ! means 
//NOT, it returns true if the data is not true.

public class LogicalOp : MonoBehaviour {
	public string luke = "Jedi";
	public string vader = "Sith";
	public bool leia = true;
	public string darkSide = "Darth Maul";
	public string lightSide = "Obi Wan";
	public int num1 = 10;
	public float num2 = 10.5f;

	Use this for initialization
	void Start () {
		if(luke == "Jedi" && vader == "Sith"){
			print("Vaders yo daddy!");
		
		}
		else if(luke== "Jawa" && vader == "Sith"){
			print("Utini!");
		}
		else if(luke=="Jedi" && vader=="Sith"){
			print("NOOOOOOOOOOOOOOOOOOO!!!!!!!!! That's not true..... that's impossible!!!");
		}
		else{
			print("The End.");
		}
	}
	
	void Start () {
	if(leia){
		print("No there's another...");
	}
	else if(!leia){
		print("Hurray!! I can date luke!!");
	}
	else{
		print("Han for lyfe.");
	}
	}
	

	void Start () {
	if(lightSide == "Obi Wan" || darkSide == "Jar Jar Binks"){
		print("Meeza Evil Sith Lorda.");
	}
	else if(lightSide == "Boba Fett" || darkSide == "Darth Maul"){
		print("As you wish, my master.");
	}
	else{
		print("Not the YOUNGLINGS!!!");
	}

}

	
	// Update is called once per frame
	void Update () {
		if(num1 == 10 && num2 == 10.5){
			print("Yes!");
		}
		else if(num1 == 10 && num2 == 10){
			print("No!");
		}
		else{
			print("Utinni!");
		}
		
	}

	void Update () {
		if(age > 21 && money > 10){
			print("Here is your drink!!");
		}
		else if(age < 21){
			print("No, get out.");
		}
		else{
			print("Sorry I can't help you.")
		}
	}

	void Update () {
		if(close){
			print("The resurrection stone.");
		}
		else if(!close){
			print("I open at the close");
		}
		else{
			print("It's the snitch I caught in my very first Quidditch match!");
		}
	}

	void Update () {
		if(wizard == "DeathEater" && password == "DarkMark"){
			print("Welcome my loyal Death Eater.");
		}
		else if(wizard == "Harry Potter"){
			print("Harry Potter, come to die.");
		}
		else{
			print("AVADAKADAVRA!!");
		}
	}

	void Update () {
		if(wizard == "Harry Potter" || wizard == "Hermione Granger" || wizard == "Ron Weasly"){
			print("GRYIFFINDOR!!!");
		}
		else if(wizard == "Luna Lovegood" || wizard == "Cho Cheng"){
			print("RAVENCLAW!!!");
		}
		else if(wizard == "Draco Malfoy"){
			print("SLYTHERIN");
		}
		else{
			print("HUFFLEPUFF!");
		}
	}

	void Update () {
		if(harry && ron && hermione){
			print("Why is it always you three?");
		}
		else if(harry || ron){
			print("Maybe if I turned one of you into a pocket watch the other would be on time.");
		}
		else{
			print("5 points from Gryffindor.")
		}
	}

	void Update () {
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
}
