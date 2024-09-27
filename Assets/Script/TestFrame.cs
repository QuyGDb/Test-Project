using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFrame : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake: " + Time.frameCount);

    }
    private void OnEnable()
    {
        Debug.Log("OnEnable: " + Time.frameCount);
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start: " + Time.frameCount);
    }
    private void FixedUpdate()
    {
        Debug.Log("Fixed Update: " + Time.frameCount);
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update: " + Time.frameCount);
    }
    void LateUpdate()
    {
        Debug.Log("Late Update: " + Time.frameCount);
    }
}
