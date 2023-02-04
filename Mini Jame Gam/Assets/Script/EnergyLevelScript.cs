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
    private TMP_InputField TextInput;
    bool upArrowPressed = false;
    bool downArrowPressed = false;
    bool leftArrowPressed = false;
    bool rightArrowPressed = false;
    void Start()
    {
        TextInput = Text.GetComponent<TMP_InputField>();
        Debug.Log(TextInput);
        TextInput.text = energy.ToString();
        Debug.Log(Text);
    }



    public void Update()
    {

        if (int.Parse(TextInput.text) == 0)
        {
            ResetLevel();
        }

        if (Input.GetKey(KeyCode.UpArrow) && !upArrowPressed)
        {
            int value = int.Parse(TextInput.text);
            value--;
            TextInput.text = value.ToString();
            upArrowPressed = true;
        }
        else if (!Input.GetKey(KeyCode.UpArrow))
        {
            upArrowPressed = false;
        }

        if (Input.GetKey(KeyCode.DownArrow) && !downArrowPressed)
        {
            int value = int.Parse(TextInput.text);
            value--;
            TextInput.text = value.ToString();
            downArrowPressed = true;
        }
        else if (!Input.GetKey(KeyCode.DownArrow))
        {
            downArrowPressed = false;
        }

        if (Input.GetKey(KeyCode.LeftArrow) && !leftArrowPressed)
        {
            int value = int.Parse(TextInput.text);
            value--;
            TextInput.text = value.ToString();
            leftArrowPressed = true;
        }
        else if (!Input.GetKey(KeyCode.LeftArrow))
        {
            leftArrowPressed = false;
        }

        if (Input.GetKey(KeyCode.RightArrow) && !rightArrowPressed)
        {
            int value = int.Parse(TextInput.text);
            value--;
            TextInput.text = value.ToString();
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

