using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player player=new Player("player1",90);
        Enemy enemy=new Enemy("enemy1",100);

        Debug.Log("Player Name : "+ player.Name +" , Player Health: "+player.Health);
        Debug.Log("Enemy Name : "+ enemy.Name +" , Enemey Health: "+enemy.Health);

        player.Heal(10);

         Debug.Log("Player Health after Heal: "+player.Health);

         enemy.Attach(player,30);

          Debug.Log("Player Health after Attach: "+player.Health);








        
    }

   
}
