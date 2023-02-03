using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour


{
    public bool Unlock = false;
    private GameObject[] MovableWithKey;
    private int arraylenght;
    void Start()
    {
        MovableWithKey = GameObject.FindGameObjectsWithTag("MovableWithKey");
        arraylenght = MovableWithKey.Length;
        




    }


    void OnTriggerEnter(Collider obj)
    {
        if (obj.transform.name == "Player")
        {
            Unlock = true;
        }
            
        
        
    }
    void Update()
    {
        if (arraylenght > 0 && Unlock == true)
        {
            for (var i = 0; i < arraylenght; i++)
            {
                DestroyImmediate(MovableWithKey[i]);
               
            }
            DestroyImmediate(this.gameObject);
        }
    }


}
  
      



