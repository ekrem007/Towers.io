﻿using UnityEngine;
public class CameraController : MonoBehaviour
{
    public Transform target;
    public float distance;
    void Update()
    {
        this.transform.position = Vector3.Slerp(this.transform.position, (-this.transform.forward * distance) + target.position, Time.deltaTime * 2);
    }
}