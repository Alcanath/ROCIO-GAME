using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePic : MonoBehaviour
{
    public GameObject pic;
    public GameObject piece;
    public Keypadray keypad;
    public Vector3 displacment;
    bool spawned;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (keypad.isCorrect && !spawned) {
            Instantiate(pic, transform);

            GameObject instance = Instantiate(piece, transform);
            instance.transform.position += displacment;
            spawned = true;
            }
    }
}
