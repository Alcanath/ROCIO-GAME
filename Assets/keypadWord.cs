using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keypadWord : MonoBehaviour {
    public LayerMask layerMask;
    public TextMesh displayText;
    public string password;
    
    string input;
    int digit = 1;
    public bool isCorrect;

    bool passwordCheck;

    // Start is called before the first frame update
    void Start() {

        }

    // Update is called once per frame
    void Update() {


        RaycastHit hitKey;
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hitKey, 100, layerMask)) {
                if (digit <= password.Length) {
                    if (hitKey.transform.tag == "Clear") {
                        print("cleared");
                        input = "";
                        digit = 0;
                        displayText.text = "";
                        } else {
                        input += hitKey.transform.tag;
                        digit++;
                        displayText.text = input;
                        }
                    
                    } else if (input == password) {
                    displayText.text = "POG";
                    input = "";
                    isCorrect = true;
                    } else if (input != password) {
                    displayText.text = "XXXX";
                    input = "";
                    digit = 1;
                    }


                print(input);




                }
            }
        }
    }
