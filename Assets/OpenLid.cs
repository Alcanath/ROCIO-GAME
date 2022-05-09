using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLid : MonoBehaviour
{
    public Keypadray keypad;
    bool opened;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (keypad.isCorrect && !opened) {
            transform.Rotate(0,0,-100);
            opened = true;
            }
    }
}
