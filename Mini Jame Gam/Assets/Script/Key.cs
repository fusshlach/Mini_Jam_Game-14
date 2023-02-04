using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Key : MonoBehaviour


{
    public bool Unlock = false;
    //private GameObject[] MovableWithKey;
    private int arraylenght;
    [SerializeField]
     PlayerMovementScript Myplayer;
    void Start()
    {
        // Myplayer.MovableWithKey = GameObject.FindGameObjectsWithTag("MovableWithKey");
       // arraylenght = Myplayer.MovableWithKey.Length;
        

    }


    void OnTriggerEnter(Collider obj)
    {
        if (obj.transform.name == "Player")
        {
            Unlock = true;
            arraylenght = Myplayer.MovableWithKey.Length;
        }
            
        
        
    }
    void Update()
    {
        if (arraylenght > 0 && Unlock == true)
        {
            for (var i = 0; i < arraylenght; i++)
            {
                Destroy(Myplayer.MovableWithKey[i]);

               
            }
           Array.Clear(Myplayer.MovableWithKey, 0, arraylenght);
            DestroyImmediate(this.gameObject);
        }
    }


}
  
      



