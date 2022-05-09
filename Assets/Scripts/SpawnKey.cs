using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnKey : MonoBehaviour
{
    Rigidbody rb;
    public GameObject key;

    bool spawnedKey;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Vector3 spawn = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (!rb.isKinematic && !spawnedKey) {
            GameObject instance = Instantiate(key);
            instance.transform.position = Vector3.zero;
            spawnedKey = true;
            }
    }
}
