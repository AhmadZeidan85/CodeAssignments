using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lecture18
{

public class GenericsTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameContainer<string> gc = new GameContainer<string>();
        gc.SetItem("Healing Potion");
        string savedItem = gc.GetItem();
        Debug.Log("Stored item: "+savedItem);

        string desciption=GameUtils.DescribeItem(savedItem);
        Debug.Log(desciption);

        
    }

}
}
