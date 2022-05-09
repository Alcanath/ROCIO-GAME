using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWord : MonoBehaviour
{
    public keypadWord keypad;
    public Transform drawer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (keypad.isCorrect) {
            drawer.localPosition = new Vector3(0, 0.68f, -0.7f);
            }
        }
}
