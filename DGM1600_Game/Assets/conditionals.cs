using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
 
public class conditionals : MonoBehaviour { 
  //Conventions and syntax 
  //each line of code needs to end with a ;  
  //{} show the beginning and end of code 
  //  
 
  public string stopLight = "Red"; 
  void start(){ 
    Main(); 
  } 
  void Main () { 
    if(stopLight == "Red") { 
    print("STOP! ThE lIgHt Is ReD!!"); 
 
    }  
    else if (stopLight == "Yellow"){  
    print("SlOw DoWn!!!"); 
    } 
    else if (stopLight == "Green"){  
    print("Go!!!!"); 
    } 
    else{ 
    print("I dOn'T kNoW wHaT yOu MeAn!"); 
    } 
 
 
} 
 
}