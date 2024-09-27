using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCoroutineVariable : MonoBehaviour
{
    private Coroutine coroutine;
    private bool isLog = true;
    // Start is called before the first frame update
    private void Start()
    {
        coroutine = StartCoroutine(DoSomethingCoroutine());
        Debug.Log(coroutine);
        Debug.Log("s1" + Time.frameCount);
    }
    // Update is called once per frame
    void Update()
    {
        if (isLog)
        {
            isLog = false;
            Debug.Log(coroutine);
            Debug.Log("u1" + Time.frameCount);
        }
    }
    private IEnumerator DoSomethingCoroutine()
    {
        Debug.Log("d2" + Time.frameCount);
        Debug.Log(coroutine);
        yield return new WaitForEndOfFrame();

        Debug.Log("d3" + Time.frameCount);
    }
}
