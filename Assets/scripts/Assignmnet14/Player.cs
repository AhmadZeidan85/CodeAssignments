using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : Character
{
   public Player(string name, int health): base(name, health){
    
       
   }

   public void Heal(int value){
    this.Health=this.Health+value;
   }


}


    

