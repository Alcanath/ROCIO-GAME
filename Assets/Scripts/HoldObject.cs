using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HoldObject : MonoBehaviour {
    public float range = 100;
    public LayerMask layerMask;
    public GameObject crosshairInteract;
    GameObject interactableHold;
    public bool isLookingAtInteract, isHoldingInteract;
    Rigidbody rb;
    MouseLook mouselook;


    void Start() {
        mouselook = gameObject.GetComponentInParent<MouseLook>();
        }

    // Update is called once per frame
    void Update() {

        mouselook.activateMouse = true;
        
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, range, layerMask)) {
            crosshairInteract.SetActive(true);
            isLookingAtInteract = true;


            if (Input.GetButtonDown("Fire1") && isHoldingInteract == false) {
                OnHit onHit = hit.transform.GetComponent<OnHit>();
                rb = hit.transform.GetComponent<Rigidbody>();
                onHit.interact();
                rb.isKinematic = true;
                isHoldingInteract = true;
                interactableHold = onHit.transform.gameObject;
                }

            } else {

            crosshairInteract.SetActive(false);
            isLookingAtInteract = false;

            }



        if (isHoldingInteract) {

            interactableHold.transform.position = transform.position;


            if (Input.GetButton("Fire2")) {
                mouselook.activateMouse = false;
                interactableHold.transform.Rotate(transform.up, -Input.GetAxis("Mouse X"));
                interactableHold.transform.Rotate(transform.right, -Input.GetAxis("Mouse Y"));
                } else {
                mouselook.activateMouse = true;
                }
            
            if (Input.GetButtonUp("Fire1")) {
                isHoldingInteract = false;
                rb.isKinematic = false;
                }
            }
        }
    }

