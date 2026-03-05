using System;
using UnityEngine;

public class ButtonEvent : MonoBehaviour
{
    public static event Action onButtonPressed;

    public void OnButtonPressed()
    {
        onButtonPressed?.Invoke();

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
