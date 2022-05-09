using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock : MonoBehaviour
{
    public GameObject door;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision) {
        print("collided");
        if (collision.transform.tag == "ClosetLeftLock") {
            door.transform.Rotate(0,90,0);
            Destroy(gameObject);
            print("isKey");
            }
        }
    }
