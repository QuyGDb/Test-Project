using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUI : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        Debug.Log(transform.position);
        Debug.Log(transform.localPosition);
        var rectTransform = GetComponent<RectTransform>();
        Debug.Log(rectTransform.anchoredPosition);
        Debug.Log(rectTransform.anchoredPosition3D);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
