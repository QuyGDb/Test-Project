using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestGetComponentInChildren : MonoBehaviour
{

    /// <summary>
    /// test xem input system có ???c g?i tr??c update nh? trong unity lifecycle: nó ?c g?i ? ?o?n Input System
    /// </summary>
    private Myproject InputAction;
    private InputAction fire;
    private ComponentToTest componentToTest;
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
        componentToTest = GetComponentInChildren<ComponentToTest>();
        Debug.Log(componentToTest);
    }
}
