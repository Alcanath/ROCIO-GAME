using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    CharacterController controller;

    public float speed = 7f;
    public float gravity = -9.81f;
    public float jumpDistance = 2f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;

    bool isGrounded;

    
    void Update() {
        //GRAVITY CHECK SCRIPT

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0) {
            velocity.y = -2f;
            }


        //PLAYER CONTROLLER MOVE METHOD
        controller = GetComponent<CharacterController>();

        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        Vector3 moveNorm = move.normalized;

        controller.Move(moveNorm * speed * Time.deltaTime);

        //JUPING SCRIPT
        if (Input.GetButtonDown("Jump") && isGrounded) {
            
            velocity.y = Mathf.Sqrt(jumpDistance * -2f * gravity);

            }
        if (Input.GetKey(KeyCode.LeftControl)) {

            Camera.main.transform.localPosition = new Vector3(0, -0.29f, 0);
            } else {
            Camera.main.transform.localPosition = Vector3.up;
            }
        




        //GRAVITY APPLICATION
        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
        }
    }
