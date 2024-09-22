using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestInput : MonoBehaviour
{
    /// <summary>
    /// test xem input system có được gọi trước update như trong unity lifecycle: nó đc gọi ở đoạn Input System
    /// nhưng không thể chắc chắn về các hàm getkeydown, vì nếu event đc invoke ở đoạn Input event thì trong update 
    /// GetMouseButtonDown sẽ thành true từ thời điểm đó đến cuối frame
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
