using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{

    public bool IsHostiles;
    public GameObject[] gameObjects;
    public GameObject[] Pause;


    void Start()
    {
        Pause = GameObject.FindGameObjectsWithTag("Loot");

    }




    void Update()
    {
        ProximityCheck();
        if (IsHostiles == false) TurnOff();
        if (IsHostiles == true) TurnOn();
        
    
    }

    void ProximityCheck()
    {
        gameObjects = GameObject.FindGameObjectsWithTag("Baddie");
        if (gameObjects.Length != 0)
        {
            IsHostiles = true;
        }
        else
        {
            IsHostiles = false;
        }        
        
    }

    void TurnOff()
    {
       foreach(GameObject i in Pause)
        {
            i.SetActive(false);
        }
    }
    void TurnOn()
    {
        foreach (GameObject i in Pause)
        {
            i.SetActive(true);
        }
    }
    

}
