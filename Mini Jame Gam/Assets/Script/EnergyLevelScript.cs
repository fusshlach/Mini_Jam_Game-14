using UnityEngine;
using UnityEngine.UI;

public class EnergyLevelScript : MonoBehaviour
{
    public InputField inputField;
    public Text 12;
    private int value = 0;

    public void OnValueChanged()
    {
        value++;
        text.text = value.ToString();
    }
}

