using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//for loops are used to repeat the same action a specific number of times. They're just like while loops
//but with different syntax. for(x;y;z) x is where you declare the varable is it hasn't been declared
//already. Looks like (;y;z). y is where you put how many times to loops iterates. z is where you put 
//the counter to make it chang iterations. For loops are used as counters and performing code multiple 
//times in a row.


public class ForLoops : MonoBehaviour {

    void Start(){
        for(int bottles = 100; bottles > 0; bottles --){
            print(bottles + " of orange crush on the wall.");
        }

        

        for(int level = 1; level < 5; level ++){
            print("You have reached level " + level);
        }



        for(int pens = 25; pens > 0; pens --){
            print("You gave your friend a pen! You have " + pens + " pens left.");
        }


    int eneimes = 10;

        for(;eneimes > 0; eneimes --){
            print("There are " + eneimes + " enemies remaining.");
        }




        for(int assignments = 20; assignments > 0; assignments --){
            print("There are " + assignments + " assignments left.");
        }



        for(int money = 0; money < 12; money ++){
            print("You have " + money + " dollars.");
        }


    int data = 8;

        for(; data > 0; data --){
            print("You have " + data + "g of data left.");
        }



        for(int hours = 72; hours > 0; hours --){
            print(hours + " remain");
        }



        for(int lv = 0; lv < 20; lv ++){
            print("YOU GAINED LOVE~ ;)");
        }

        for(int miles = 0; miles < 500; miles ++){
            print("I would walk 500 hundred miles and I would walk " + miles + " more just to be the man who walks a thousand miles to fall down at your door");
        }


    }


}