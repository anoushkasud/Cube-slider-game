using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public Rigidbody r;
    public Vector3 offset;
    public Camera cam;
    private void Start()
    {
        cam = GetComponent<Camera>();
    }
    private void FixedUpdate()
    {
        cam.transform.position = r.transform.position + offset;
    }
}
