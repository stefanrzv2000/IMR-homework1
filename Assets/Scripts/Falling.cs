using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    //int count = 0;
    private Rigidbody rbody;
    GameObject cam;
    GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("ARCamera");
        target = GameObject.Find("ImageTarget");
        rbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 delta = cam.transform.position - target.transform.position;
        float dist = delta.magnitude;
        
        //count++;
        //if (Input.GetKeyDown("space") || Input.touchCount > 0)
        //{
        //    Debug.Log(cam.transform.position.ToString());
        //    Debug.Log(target.transform.position.ToString());
        //    Debug.Log(dist);
        //    rigidbody.useGravity = true;
        //}

        if(dist > 0 && dist < 2.5f)
        {
            rbody.useGravity = true;
        }
    }
}
