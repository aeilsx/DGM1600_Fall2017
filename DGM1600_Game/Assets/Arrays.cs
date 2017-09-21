using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
	
	// Update is called once per frame
	void Update () {
		
	}
}
