using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHit : MonoBehaviour
{
    bool didInteract;

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "outOfBoundsPlane") {
            transform.position = new Vector3(0, 0, 0);
            }
        }


    public void interact() {

        }


}
