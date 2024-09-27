using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestYield : MonoBehaviour
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
        fire.performed += OnFire;

    }
    private void OnDisable()
    {
        fire.Disable();
        fire.performed -= OnFire;
    }
    void OnFire(InputAction.CallbackContext callbackContext)
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Before call coroutine: " + Time.frameCount);

        StartCoroutine(YieldEndFrameCoroutine());
        StartCoroutine(YieldNullCoroutine());
        Debug.Log("After call coroutine: " + Time.frameCount);
    }
    private void FixedUpdate()
    {
        // Debug.Log("Fixed Update " + Time.frameCount);
    }
    private void Update()
    {
        Debug.Log("Update: " + Time.frameCount);
    }

    IEnumerator YieldNullCoroutine()
    {
        Debug.Log("Before Yield Null: " + Time.frameCount);
        yield return null;
        Debug.Log("After Yield Null: " + Time.frameCount);
    }
    IEnumerator YieldEndFrameCoroutine()
    {
        Debug.Log("Before Yield end frame: " + Time.frameCount);
        yield return new WaitForEndOfFrame();
        Debug.Log("After Yield end frame: " + Time.frameCount);
    }
    IEnumerator YieldNullAndEndFrame()
    {
        Debug.Log("Before Yield null: " + Time.frameCount);
        yield return null;
        Debug.Log("After Yield null: " + Time.frameCount);
        yield return new WaitForEndOfFrame();
        Debug.Log("After end frame: " + Time.frameCount);

    }
    IEnumerator YieldEndFrameAndNull()
    {
        Debug.Log("Before Yield end frame: " + Time.frameCount);
        yield return new WaitForEndOfFrame();
        Debug.Log("After Yield end frame: " + Time.frameCount);
        yield return null;
        Debug.Log("After null: " + Time.frameCount);

    }
    IEnumerator YieldFixedUpdatedCoroutine()
    {
        Debug.Log("Before Yield fixed update: " + Time.frameCount);
        yield return new WaitForFixedUpdate();
        Debug.Log("After Yield fixed update: " + Time.frameCount);
    }
}
