using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment16{

public struct Position 
{
     public float x;
     public float y;
     public float z;
       

        public Position(float x, float y , float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void printPosition(){

            Debug.Log("Position Data: x value is: " + this.x +" , y value is: "+ this.y+ " , z value is: "+this.z);

        }
    
}

}