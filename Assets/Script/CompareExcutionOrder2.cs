using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompareExcutionOrder2 : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake2: " + Time.frameCount);
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start2: " + Time.frameCount);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update2: " + Time.frameCount);
    }
}
