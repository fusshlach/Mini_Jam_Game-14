using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour


{
    public bool Unlock = false;
    private GameObject[] MovableWithKey;
    void Start()
    {
        MovableWithKey = GameObject.FindGameObjectsWithTag("MovableWithKey");




    }


    void OnTriggerEnter(Collider obj)
    {
        if (obj.transform.name == "Player")
            Unlock = true;
    }
}
  
      



