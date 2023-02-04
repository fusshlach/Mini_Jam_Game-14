using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishScript : MonoBehaviour
{
    [SerializeField]
    EnergyLevelScript MyEnergy;
    public bool Victory = false;
    public Image mgraph;
    private float alph = 0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Victory == true)
        {
            Color Newcolor = new Color(1f, 1f, 1f, alph);
            mgraph.color = Newcolor;
            alph += 0.001f;
            if (alph > 1)
            {
                SceneManager.LoadScene("Level01");
            }
        }
        
    }
    void OnTriggerEnter(Collider obj)
    {
        if (obj.transform.name == "Player")
        {
            if (MyEnergy.energy == 0)
            {
                Victory = true;
                Debug.Log(Victory);
            }
            
           
        }



    }
}
