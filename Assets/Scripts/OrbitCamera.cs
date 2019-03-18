﻿using UnityEngine;
using System.Collections;

public class OrbitCamera : MonoBehaviour {
    [SerializeField] private Transform target;

    public float rotSpeed = 1.5f;

    private float _rotY;
    private Vector3 _offset;

    // Start is called before the first frame update
    void Start() {
        _rotY = transform.eulerAngles.y;
        _offset = target.position - transform.position;
    }

    // Update is called once per frame
    void LateUpdate() {
        float horInput = Input.GetAxis("Horizontal");
        if (horInput != 0) {
            _rotY += horInput * rotSpeed;
        } else {
            _rotY += Input.GetAxis("Mouse X");
        }

        Quaternion rotation = Quaternion.Euler(0, _rotY, 0);
        transform.position = target.position - (rotation * _offset);
        transform.LookAt(target);
    }
}
