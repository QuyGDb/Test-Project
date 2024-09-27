using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestInput : MonoBehaviour
{
    /// <summary>
    /// test xem input system có được gọi trước update như trong unity lifecycle: nó đc gọi ở đoạn Input System
    /// </summary>
    private Myproject InputAction;
    private InputAction fire;

    private void Awake()
    {
        InputAction = new Myproject();
    }
    private void OnEnable()
    {

        fire = InputAction.Player.Fire;
        fire.Enable();
        fire.performed += OnFire;

    }

    private void OnDisable()
    {
        fire.Disable();
        fire.performed -= OnFire;
    }
    void OnFire(InputAction.CallbackContext callbackContext)
    {
        Debug.Log("Fire" + Time.frameCount);
        Debug.Log(Input.GetMouseButtonDown(0) + " abc " + Time.frameCount);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            Debug.Log("true" + Time.frameCount);
        }

    }
    private void OnMouseDown()
    {
        Debug.Log(Input.GetMouseButtonDown(0) + " mouse " + Time.frameCount);
        Debug.Log("Mouse Down" + Time.frameCount);
    }


}
