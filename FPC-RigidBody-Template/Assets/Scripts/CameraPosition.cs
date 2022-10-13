using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    public Transform cameraPosition;
    void FixedUpdate()
    {
        transform.position = cameraPosition.position;
    }
}
