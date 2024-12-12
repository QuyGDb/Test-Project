using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestOverlappingInSameFrame : MonoBehaviour
{
    public BoxCollider boxCollider;
    public CallCoroutine callCoroutine;
    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider>();
    }
    private void OnEnable()
    {
        Debug.Log("OnEnable" + gameObject.name + Time.frameCount);
        ProcessOverlapping();
    }

    public void ProcessOverlapping()
    {
        Collider[] hitColliders = new Collider[1];
        hitColliders = Physics.OverlapBox(boxCollider.bounds.center, boxCollider.size, Quaternion.identity);
        foreach (var hitCollider in hitColliders)
        {
            if (hitCollider != boxCollider)
            {
                Debug.Log("Overlapping" + gameObject.name + Time.frameCount + hitCollider.name);
                this.gameObject.transform.position = new Vector3(transform.position.x + 10, transform.position.y + 10, transform.position.z);
                callCoroutine.CallCoroutineTemp(this);
            }
        }
    }

}
