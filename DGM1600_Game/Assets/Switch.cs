using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
	
	// Update is called once per frame
	void Update () {
		
	}
}
