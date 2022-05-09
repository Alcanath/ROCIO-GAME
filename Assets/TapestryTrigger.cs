using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapestryTrigger : MonoBehaviour
{
    public GameObject staticTapestry;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision) {
        
        if (collision.transform.tag == "Finish") {
            Destroy(collision.gameObject);
            staticTapestry.SetActive(true);
            }
        }
    }
