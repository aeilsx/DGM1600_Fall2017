using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class IfElse : MonoBehaviour {

    //the else statement is for when the if conditonal isn't met and you want an alternative action.
    //theres not much more to say than that.

    public bool late = false;
    public int dollars;
    public int chickens = 9;

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


    }

    
}