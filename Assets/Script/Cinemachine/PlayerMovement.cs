using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Myproject inputActions;
    InputAction movement;
    [SerializeField] private float speed;
    Animator animator;
    private void Awake()
    {
        inputActions = new Myproject();
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
        animator.SetFloat("Speed", moveInput.magnitude);
        Vector3 move = new Vector3(moveInput.x, 0, moveInput.y);
        transform.position += move * speed * Time.deltaTime;
    }
}
