using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerWordKeypad : MonoBehaviour {
    public GameObject spawn;
    public GameObject spawnOther;
    bool shouldSpawn;
    bool spawned;
    public keypadWord keypad;
    public Vector3 location = new Vector3(0.9f, -0.6f, 2f);

    // Start is called before the first frame update
    void Start() {


        }

    // Update is called once per frame
    void Update() {
        shouldSpawn = keypad.isCorrect;

        if (shouldSpawn && !spawned) {
            GameObject instance = Instantiate(spawn);
            instance.transform.position = location;
            spawned = true;

            GameObject instanceOther = Instantiate(spawnOther);
            instanceOther.transform.position = new Vector3(.2f, -0.6f, 2f);
            }
        }
    }
