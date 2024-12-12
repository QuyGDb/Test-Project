using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestOrder : MonoBehaviour
{
    /// <summary>
    /// test xem input system có được gọi trước update như trong unity lifecycle: nó đc gọi ở đoạn Input System
    /// </summary>
    private Myproject InputAction;
    private InputAction fire;

    private void Awake()
    {
        var x = new GameObject("X");
        x.AddComponent<SubTest>();

        var y = new GameObject("Y");
        y.AddComponent<SubTest>();
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
    //private void Start()
    //{
    //    var x = new GameObject("X");
    //    x.AddComponent<SubTest>();

    //    var y = new GameObject("Y");
    //    y.AddComponent<SubTest>();
    //}
    void OnFire(InputAction.CallbackContext callbackContext)
    {
        var x = new GameObject("X");
        x.AddComponent<SubTest>();

        var y = new GameObject("Y");
        y.AddComponent<SubTest>();
    }
    // test thứ tự gọi của các object được instantiate trong update()
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var x = new GameObject("X");
            x.AddComponent<SubTest>();

            var y = new GameObject("Y");
            y.AddComponent<SubTest>();

        }
    }

    private class SubTest : MonoBehaviour
    {
        private void Awake()
        {
            Debug.Log($"{name} Awake: {Time.frameCount}");
        }

        private void Start()
        {
            Debug.Log($"{name} Start: {Time.frameCount}");
        }

        private bool firstUpdate;

        private void Update()
        {
            if (firstUpdate)
            {
                Destroy(gameObject);
                return;
            }

            firstUpdate = true;
            Debug.Log($"{name} First Update: {Time.frameCount}");
        }
    }
}