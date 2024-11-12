using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment16{
public class Character 
{
    public string name;
    private int health;
    protected Position position;

      public int Health  // Property
    {
        get { return health;}
        set { if (value> 100) health = 100;
              else if (value < 0) health = 0;
              else health = value;
            }
    }

    public Character(string name, int health, Position position){
        this.name=name;
        this.health=health;
        this.position = position;
    }

    public Character() : this("No name", 100, new Position(0, 0, 0)) { }

    public virtual void DisplayInfo(){

        Debug.Log("Name is: "+ this.name+ " , health is: " + Health);
        this.position.printPosition();


    }

    public void Attack(int damage, Character character ){
    this.Attack(damage,character,"defaultAttack");
   }

   
    public void Attack(int damage, Character character, string attackType ){
    if(attackType=="defaultAttack"){
    character.Health=character.Health-damage;
    }
    else if (attackType=="shooting"){
         character.Health=character.Health-(damage*3);
         }

     else if (attackType=="kicking"){
        character.Health=character.Health-(damage*2);

    }
   }


   
}
}
