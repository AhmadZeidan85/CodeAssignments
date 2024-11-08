using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character 
{
    private string name ;
    private int health = 100;

     public Character(string name, int health)
    {
        this.name = name;
        this.health = health;
       
    }

    public string Name     
    {
        get 
            { 
              return name;  
            }
        set { 
               name = value;
             
            }                             
    }

    public int Health  // Property
    {
        get { return health;}
        set { if (value> 100) health = 100;
              else if (value < 0) health = 0;
              else health = value;
            }
    }
   
}
