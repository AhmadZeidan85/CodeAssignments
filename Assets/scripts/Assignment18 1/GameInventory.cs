using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture18
{
public class GameInventory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Inventory potionsInventory = new Inventory();
        potionsInventory.AddItem("Healing Potion");
        potionsInventory.AddItem("Strength Potion");

    
        Inventory elixirsInventory = new Inventory();
        elixirsInventory.AddItem("Elixir");
        elixirsInventory.AddItem("Dark Elixir");

     
        Inventory combinedInventory = potionsInventory + elixirsInventory;

        combinedInventory.ShowItems();
        
    }

  
}

}