using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class EnergyLevelScript : MonoBehaviour
{
    // public InputField inputField;
    public int energy = 12;
    [SerializeField]
    public GameObject Text;
    [SerializeField]
    FinishScript MyFinish;
    private TMP_InputField TextInput;
    bool upArrowPressed = false;
    bool downArrowPressed = false;
    bool leftArrowPressed = false;
    bool rightArrowPressed = false;
    private float timer = 0f;
    void Start()
    {
        TextInput = Text.GetComponent<TMP_InputField>();
        Debug.Log(TextInput);
        TextInput.text = energy.ToString();
        Debug.Log(Text);
    }



    public void Update()
    {

        if (energy == 0&&MyFinish.Victory ==false)
        {
            timer += 1;
            if (timer >10&&MyFinish.Victory == false)
            {
                ResetLevel();
            }
            
        }

        if (Input.GetKey(KeyCode.UpArrow) && !upArrowPressed)
        {
           
            energy--;
            TextInput.text = energy.ToString();
            upArrowPressed = true;
        }
        else if (!Input.GetKey(KeyCode.UpArrow))
        {
            upArrowPressed = false;
        }

        if (Input.GetKey(KeyCode.DownArrow) && !downArrowPressed)
        {
            energy--;
            TextInput.text = energy.ToString();
            downArrowPressed = true;
        }
        else if (!Input.GetKey(KeyCode.DownArrow))
        {
            downArrowPressed = false;
        }

        if (Input.GetKey(KeyCode.LeftArrow) && !leftArrowPressed)
        {
            energy--;
            TextInput.text = energy.ToString();
            leftArrowPressed = true;
        }
        else if (!Input.GetKey(KeyCode.LeftArrow))
        {
            leftArrowPressed = false;
        }

        if (Input.GetKey(KeyCode.RightArrow) && !rightArrowPressed)
        {
            energy--;
            TextInput.text = energy.ToString();
            rightArrowPressed = true;
        }
        else if (!Input.GetKey(KeyCode.RightArrow))
        {
            rightArrowPressed = false;
        }
    }

    public void ResetLevel()
    {


        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        // Code to reset the level goes here, for example:

    }
}

