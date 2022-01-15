using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject c;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - c.transform.position;
    }

    // Last Function called every frame
    void LateUpdate()
    {
        transform.position = c.transform.position + offset;
    }
}
