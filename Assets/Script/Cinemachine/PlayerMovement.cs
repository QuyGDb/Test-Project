using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Myproject inputActions;
    InputAction movement;
    [SerializeField] private float speed;
    private CharacterController controller;
    Animator animator;
    private void Awake()
    {
        inputActions = new Myproject();
        controller = GetComponent<CharacterController>();
        movement = inputActions.Player.Move;
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        movement.Enable();
    }
    private void OnDisable()
    {
        movement.Disable();
    }

    private void Update()
    {

        Vector2 moveInput = movement.ReadValue<Vector2>();
        //animator.SetFloat("Speed", moveInput.magnitude);
        //Vector3 move = transform.right * moveInput.x + transform.forward * moveInput.y;
        //  controller.Move(speed * Time.deltaTime * move);
        //  transform.Translate(new Vector3(moveInput.x, 0, moveInput.y) * speed * Time.deltaTime, Space.World);
        transform.localPosition += new Vector3(moveInput.x, 0, moveInput.y) * speed * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.localRotation = Quaternion.Euler(0, 90, 0);
        }
    }
}
