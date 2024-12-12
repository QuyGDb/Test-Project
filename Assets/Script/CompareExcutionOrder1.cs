using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompareExcutionOrder1 : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake1: " + Time.frameCount);
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start1: " + Time.frameCount);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update1: " + Time.frameCount);
    }
}
