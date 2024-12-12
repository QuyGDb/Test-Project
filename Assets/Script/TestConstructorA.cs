using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestContructorA : MonoBehaviour, ISerializationCallbackReceiver
{
    int count1 = 0;
    int count2 = 0;
    public TestContructorA()
    {
        count1++;
        Debug.Log("Constructor A" + count1);
    }

    public void OnAfterDeserialize()
    {
        count2++;
        Debug.Log("OnAfterDeserialize" + count2);
    }

    public void OnBeforeSerialize()
    {
        //  Debug.Log("OnBeforeSerialize");
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
