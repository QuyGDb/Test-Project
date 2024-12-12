using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestContructorB : MonoBehaviour, ISerializationCallbackReceiver
{
    public TestContructorB()
    {
        Debug.Log("Constructor B");
    }
    public void OnAfterDeserialize()
    {
        Debug.Log("OnAfterDeserialize2");
    }

    public void OnBeforeSerialize()
    {
        //  Debug.Log("OnBeforeSerialize2");
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
