using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallCoroutine : MonoBehaviour
{
    public void CallCoroutineTemp(TestOverlappingInSameFrame testOverlappingInSameFrame)
    {
        StartCoroutine(Process(testOverlappingInSameFrame));
    }
    public IEnumerator Process(TestOverlappingInSameFrame testOverlappingInSameFrame)
    {
        testOverlappingInSameFrame.gameObject.SetActive(false);
        yield return new WaitForSeconds(1);
        testOverlappingInSameFrame.gameObject.SetActive(true);
    }
}
