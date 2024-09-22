using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewBehaviourScript : MonoBehaviour
{
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
        fire.performed += ctx => Debug.Log("Fire" + Time.frameCount);
    }
    private void OnDisable()
    {
        fire.Disable();
        fire.performed -= ctx => Debug.Log("Fire");
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
        Debug.Log("Mouse Down" + Time.frameCount);
    }


}
