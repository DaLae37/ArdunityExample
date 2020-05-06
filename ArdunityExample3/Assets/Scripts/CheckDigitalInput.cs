using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ardunity;
public class CheckDigitalInput : MonoBehaviour
{
    public Text text;
    public DigitalInput digitalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Input Value : " + digitalInput.Value;
    }
}
