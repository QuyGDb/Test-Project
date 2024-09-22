using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestOrder : MonoBehaviour
{
    // test thứ tự gọi của các object được instantiate trong update()
    private void Start()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var x = new GameObject("X");
            x.AddComponent<SubTest>();

            var y = new GameObject("Y");
            y.AddComponent<SubTest>();
        }
    }

    private class SubTest : MonoBehaviour
    {
        private void Awake()
        {
            Debug.Log($"{name} Awake: {Time.frameCount}");
        }

        private void Start()
        {
            Debug.Log($"{name} Start: {Time.frameCount}");
        }

        private bool firstUpdate;

        private void Update()
        {
            if (firstUpdate)
            {
                Destroy(gameObject);
                return;
            }

            firstUpdate = true;
            Debug.Log($"{name} First Update: {Time.frameCount}");
        }
    }
}