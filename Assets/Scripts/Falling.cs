using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    int count = 0;
    private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        if (Input.GetKeyDown("space") || Input.touchCount > 0)
        {
            rigidbody.useGravity = true;
        }
    }
}
