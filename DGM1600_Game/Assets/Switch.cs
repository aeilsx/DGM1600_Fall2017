using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Switch statements are used to present multiple variables and test one against another 
//variable. A switch has cases and the value of the variable is tested against each case and 
//if not present is equal to the default option. They can be used as strings and even 
//to perform different operations depending on the value of the variable.

public class Switch : MonoBehaviour {
	public string townCenter = "main"; 


	// Use this for initialization
	void Start () {
		switch(townCenter){
			case "main":
				print("Welcome to Main Street!!");
			break;
			case "blacksmith":
				print("The blacksmith grumbles as you pick through the sword bin");
			break;
			case "bakery":
				print("MMmmmmmmmmmmmmMMMMmMmMMMmMMmmMMMmMMMmMMMmMmmMMMMMM!");
			break;
			case "morgue":
				print("Icy dead people.");
			break;
			default:
				print("I don't know what you're talking about?");
			break;
		}
		
	}
	public int level = 5;

	// Update is called once per frame
	void Start () {
		switch(level){
			case 5:
				print("You have reached level 5!");
			break;
			case 4:
				print("You have reached level 4!");
			break;
			case 3:
				print("You have reached level 3!");
			break;
			case 2:
				print("You have reached level 2!");
			break;
			case 1:
				print("You have reached level 1!");
			break;
			default:
				print("Level not accepted");
			break;

		}
	}

	public string race = "Nord";

	void Start () {
		switch(race){
			case "Nord":
				print("You picked a bad time to come home to Skyrim, kinsman.");
			break;
			case "Brenton":
				print("You from Daggerfall, Brenton? Fleeing from some court intrigue?");
			break;
			case "Dark Elf":
				print("Another refugee? Gods really have abandoned your people, dark elf.")
			break;
			default:
				print("Error");
			break;
		}
		
	}

	public string candy = "Snickers";

	void Start () {
		switch(candy){
			case "Snickers":
				print("That'll be $3.50.");
			break;
			case "M&Ms":
				print("That'll be $2.75.");
			break;
			case "Twix":
				print("That'll be $3.00.");
			break;
			case "One Hundred Grand":
				print("That'll be $100,000.");
			break;
			default:
				print("We don't have that in stock, sorry.");
			break;
		}
	}


	public string trafficLight = "Green";

	void Start () {
		switch(trafficLight){
			case "Green":
				print("Go!");
			break;
			case "Yellow":
				print("Slow down!");
			break;
			case "Red":
				print("Stop!");
			break;
			default:
				print("I dunno man. Probably just blow up.");
			break;
		}
		
	}

	public string password = "Bread makes you fat!?";

	void Start () {
		switch(password){
			case "Bread makes you fat!?":
				print("Connected to: Garlic Bread");
			break;
			default:
				print("Incorrect password");
			break;
		}	
	}

	public int callOptions = 3;

	void Start () {
		switch(callOptions){
			case 3:
				print("Stay on the line and you will be connected to customer services.");
			break;
			case 2:
				print("Our hours are 9 to 5 Monday through Friday.")
			break;
			case 1:
				print("Please leave a message at the tone.");
			break;
			default:
				print("Selection not available. Goodbye.");
			break;
		}

	}

	public string gender = "Male";

	void Start () {
		switch(gender){
			case "Male":
				print("Good day sir!");
			break;
			case "Female":
				print("Good day my lady!");
			break;
			default:
				print("Good day!");
			break;
		}	
	}

	public string class = "paladin";

	void Start () {
		switch(class){
			case "paladin":
				print("Hello Paladin! Please take the passage on the right!");
			break;
			case "soldier":
				print("Hello Soldier! Please take the middle passage.");
			break;
			case "mage":
				print("Hello Mage. Please select the passage on the right!");
			break;
			default:
				print("Hello! I recommend turning back. Or advance if you dare.");
			break;
		}
	}

	public string name = "Frisk";

	void Start () {
		switch(name){
			case "Frisk":
				print("WARNING: This name will make your life hell. Proceed anyway?");
			break;
			case "Flowey":
				print("I already CHOSE that name.");
			break;
			case "sans":
				print("nope.");
			break;
			case "Undyne":
				print("Get your OWN name!");
			break;
			case "Papyru":
				print("I'LL ALLOW IT!!!!");
			break;
			default:
				print("Is this name correct?");
			break;
		}
	}

}
