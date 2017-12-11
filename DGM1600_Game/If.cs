using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class IfElse : MonoBehaviour {

    //the if statemnet is a conditional. In code if you want something to happen but only if certain requirements met
    //you'd use an if statement. They are really flexable as well. you can do if else statements that add another conditional
    //if the first isn't met or an else statemnet if no requirements are met.

    public bool late = false;
    public int dollars;
    public int chickens = 9;
    public Transform target;

    void Start(){
        if(late == true){
            print("Go to bed");
        }
        else{
            print("Get to work!");
        }



    

        if(chickens <= 0){
            print("there are no more chickens. Game over.");
        }
        else{
            print("keep going!");
        }






        if(chickens >= 0 && late == true){
            --chickens;
            print("Goodnight Chickens");
        }
        else{
            print("RUN!");
        }

    



        if(dollars >= 10){
            print("Thank you for your purchase.");
        }
        else{
            print("You do not have enough money, sorry.");
        }





        if(late == true && dollars <= 0){
            print("Things will get better, go to sleep.");
        }
        else{
            print("Noice!!");
        }




        if(other.gameObject.name == "Player"){
            transform.LookAt(target);
            transform.Translate(Vector3.back*-moveSpeed*Time.deltaTime);
            }





        if(wizard == "DeathEater" && password == "DarkMark"){
			print("Welcome my loyal Death Eater.");
		}




        if(num1 == 10 && num2 == 10.5){
			print("Yes!");
		}
		else if(num1 == 10 && num2 == 10){
			print("No!");
		}
		else{
			print("Utinni!");
		}



        if(health != null){
			health.TakeDamage(damage);
		}




        if(countDown <= 0){
			countDown = Random.Range(0.5f,5f);
			Turn();
			moveSpeed = Random.Range(2f,5f);
		}

    }

    
}