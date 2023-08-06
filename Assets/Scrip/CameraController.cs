using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform _taget;
    [SerializeField] private float speed;

    private Vector3 _offset;
    private Vector3 _currenVelocity = Vector3.zero;
    private void Awake()
    {
        _offset = transform.position - _taget.position;
    }
    private void Update()
    {
        Vector3 tagetPosition = _taget.position + _offset;
        transform.position = Vector3.SmoothDamp(transform.position, tagetPosition, ref _currenVelocity, speed);
    }
}
