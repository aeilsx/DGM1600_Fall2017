using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOp : MonoBehaviour {
	public string luke = "Jedi";
	public string vader = "Sith";
	public bool leia = true;
	public string darkSide = "Darth Maul";
	public string lightSide = "Obi Wan";
	public int num1 = 10;
	public float num2 = 10.5f;

	// Use this for initialization
	// void Start () {
	// 	if(luke == "Jedi" && vader == "Sith"){
	// 		print("Vaders yo daddy!");
		
	// 	}
	// 	else if(luke== "Jawa" && vader == "Sith"){
	// 		print("Utini!");
	// 	}
	// 	else if(luke=="Jedi" && vader=="Sith"){
	// 		print("NOOOOOOOOOOOOOOOOOOO!!!!!!!!! That's not true..... that's impossible!!!");
	// 	}
	// 	else{
	// 		print("The End.");
	// 	}
	// }
	
	//void Start () {
	// if(leia){
	// 	print("No there's another...");
	// }
	// else if(!leia){
	// 	print("Hurray!! I can date luke!!");
	// }
	// else{
	// 	print("Han for lyfe.");
	// }
	//}
	//

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
}
