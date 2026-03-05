using UnityEngine;
using TMPro;

public class UIListener : MonoBehaviour
{
    public TextMeshProUGUI statusText;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ButtonEvent.onButtonPressed += UpdateText;
    }

    // Update is called once per frame
    void Update()
    {
        ButtonEvent.onButtonPressed -= UpdateText;
    }

    void UpdateText()
    {
        statusText.text = "Button Pressed";
    }
}
