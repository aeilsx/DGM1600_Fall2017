using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//while loops test each condition against each other and executes the expresstion until it's proven false.
//can be infinate or a certain amount of loops. It can be used to repeat actions until the conditions are fuffilled and can be used with 
//for loops and more. Uses a counter usually. 

public class While : MonoBehaviour {

	public int bottles= 0;
	// Use this for initialization
	void Start () {
		while(bottles < 100){
			bottles ++;
			print(bottles + "bottles of beer on the wall!!");
		}

	public int points = 0;
	
	//point counter
	while(points < 25){
		points ++:
		print("UVU" + points);	
	}

	//countdown
	public int time;

	while(time > 0){
		time --;
		print(time);
	}

	//hits
	public int health = 30;

	while(health >= 1){
		health --;
		print("-1 Health");
	}

	//hunger
	public int hunger = 0;

	while(hunger < 100){
		hunger ++;
		print("Eat as much as you want!!");
	}
	
	//seats available
	public int seats = 60;

	while(seats > 0){
		seats --;
		print(seats + "seats left!");
	}

	//baking
	public int cups;

	while(cups < 2){
		cups ++;
		print("Add a cup of flour.");
	}

	//homework
	public int assignments;

	while(assignments > 0){
		assignments --;
		print("One down " + assignments + "left to go.");
	}

	//eneimes
	public int enemy = 20;

	while(enemy >= 0){
		enemy --;
		print(enemy + "Enemies remain.");
	}

	//friends
	public int friend = 0;

	while(friend < 80){
		friend ++;
		print("I have" + friend + "friends!!");
	}

	}
}
