using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishScript : MonoBehaviour
{
    [SerializeField]
    EnergyLevelScript MyEnergy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider obj)
    {
        if (obj.transform.name == "Player")
        {
            if (MyEnergy.energy == 0)
            {

            }
            
           
        }



    }
}
