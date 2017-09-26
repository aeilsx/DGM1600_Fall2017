using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Arrays are used to hold multiple varibles.
//Arrays are place holders for different values. They start at 0 so there could be 12
//variables but they start at 0. You have to make the array public to make the variables
//accessable

public class Arrays : MonoBehaviour {

	public string[] heros = new string[6];
	//declared the array
	
	// Use this for initialization
	void Start () {
	heros[0] = "Batman";
	heros[1] = "Superman";
	heros[2] = "Wonder Woman";
	heros[3] = "He-Man";
	heros[4] = "Spiderman";
	heros[5] = "Thor";	

	print(heros[3]);
	}

	public string[] colors = new string[6];
	
	void Start () {
		colors[0] = "red";
		colors[1] = "orange";
		colors[2] = "yellow";
		colors[3] = "green";
		colors[4] = "blue";
		colors[5] = "purple";
	}

	public int[] points = new int[8];
	
	void Start () {
		points[0] = 50;
		points[1] = 2;
		points[2] = 26;
		points[3] = 19;
		points[4] = 35;
		points[5] = 48;
		points[6] = 29;
		points[7] = 10;
	}

	public string[] inventory = new string[9];
	
	void Start () {
		inventory[0] = "grass block";
		inventory[1] = "bucket";
		inventory[2] = "rose";
		inventory[3] = "birch wood planks";
		inventory[4] = "cobble stone";
		inventory[5] = "pink wool";
		inventory[6] = "pickaxe";
		inventory[7] = "shovel";
		inventory[8] = "sword";
	}

	public string[] gun = new string[4];
	
	void Start () {
		gun[0] = "pistol";
		gun[1] = "shotgun";
		gun[2] = "sniper rifle";
		gun[3] = "rocket launcher";
	}

	public string[] eggs = new string[6];
	
	void Start () {
		eggs[0] = "bad";
		eggs[1] = "good";
		eggs[2] = "good";
		eggs[3] = "good";
		eggs[4] = "good";
		eggs[5] = "good";
	}

	public int[] kills = new int[5];
	
	void Start () {
		kills[0] = 4;
		kills[1] = 2;
		kills[2] = 0;
		kills[3] = 10;
		kills[4] = 5;
	}

public string[] list = new string[8];
	
	void Start () {
		list[0] = "milk";
		list[1] = "bacon";
		list[2] = "lettuce";
		list[3] = "sunflower seeds";
		list[4] = "tea kettle";
		list[5] = "new mascara";
		list[6] = "curtain rod";
		list[7] = "bleach";
		
	}

public string[] shelf = new string[5];
	
	void Start () {
		shelf[0] = "meds";
		shelf[1] = "soda";
		shelf[2] = "soda";
		shelf[3] = "beer";
		shelf[4] = "meds";
		
	}

	public string[] villagers = new string[10];
	//Animal crossing <3
	
	void Start () {
		villagers[0] = "fauna";
		villagers[1] = "whitney";
		villagers[2] = "lolly";
		villagers[3] = "goldie";
		villagers[4] = "lobo";
		villagers[5] = "marshall":
		villagers[6] = "cookie";
		villagers[7] = "genji";
		villagers[8] = "diana";
		villagers[9] = "melba";
		
	}

