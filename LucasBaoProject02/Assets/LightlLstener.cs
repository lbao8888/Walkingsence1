using UnityEngine;

public class LightListener : MonoBehaviour
{
    public Light scenceLight;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ButtonEvent.onButtonPressed += ChangeLight;
    }

    // Update is called once per frame
    void Update()
    {
        ButtonEvent.onButtonPressed -= ChangeLight;
    }

    void ChangeLight()
    {
        scenceLight.color = Random.ColorHSV();
    }
}
