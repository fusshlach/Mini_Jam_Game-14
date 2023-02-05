using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Key : MonoBehaviour


{
    public bool Unlock = false;
    public AudioSource audioSource;
    //private GameObject[] MovableWithKey;
    private int arraylenght;
    [SerializeField]
    Vague fx;
    //public GameObject vague;
    [SerializeField]
    PlayerMovementScript Myplayer;
   // private float timer;
    void Start()
    {

        audioSource = GetComponent<AudioSource>();
        // Myplayer.MovableWithKey = GameObject.FindGameObjectsWithTag("MovableWithKey");
        // arraylenght = Myplayer.MovableWithKey.Length;


    }


    void OnTriggerEnter(Collider obj)
    {
        if (obj.transform.name == "Player")
        {
            Unlock = true;
            audioSource.Play();
            arraylenght = Myplayer.MovableWithKey.Length;

        }
            
        
        
    }
    void Update()
    {
        if (arraylenght > 0 && Unlock == true)
        {
            fx.FX = true;
           // timer-=0.01f;
           // vague.transform.position = vague.transform.position+new Vector3(0,timer,0);
            for (var i = 0; i < arraylenght; i++)
            {
                Destroy(Myplayer.MovableWithKey[i]);

               
            }
           Array.Clear(Myplayer.MovableWithKey, 0, arraylenght);
            DestroyImmediate(this.gameObject);
        }
    }


}
  
      



