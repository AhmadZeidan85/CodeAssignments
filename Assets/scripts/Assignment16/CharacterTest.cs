using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment16{
public class CharacterTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Character soldier = new Soldier();
        Character officer = new Officer("Ahmad Zeidan", 90, new Position(5f, 5f, 5f));

         Character[] characters = { soldier, officer };

            // Use a for loop to call DisplayInfo on each element in the array
            for (int i = 0; i < characters.Length; i++)
            {
                characters[i].DisplayInfo();
            }
        
    }

   
}

}