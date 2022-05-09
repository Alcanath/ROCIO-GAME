using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour
{
    public Keypadray keypad;
    public GameObject door;
    bool done;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (keypad.isCorrect && !done) {
            door.transform.Rotate(0,90f,0);
            done = true;
            }
    }
}
