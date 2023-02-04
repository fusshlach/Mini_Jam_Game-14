using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class EnergyLevelScript : MonoBehaviour
{
   // public InputField inputField;
    public int energy = 12;
    [SerializeField]
    public GameObject Text;
    private TMP_InputField TextInput;
    void Start()
    {
        TextInput = Text.GetComponent<TMP_InputField>();
        Debug.Log(TextInput);
        TextInput.text = energy.ToString();
        Debug.Log(Text);
    }

    public void OnValueChanged()
    {
    }
}

