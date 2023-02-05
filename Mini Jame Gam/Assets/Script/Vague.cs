using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Vague : MonoBehaviour
{
    public GameObject vague;
    private float timer;
    public bool FX = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(FX == true)
        {
            timer -= 0.00005f;
            vague.transform.position = vague.transform.position+new Vector3(0,timer,0);
        }
    }
}
