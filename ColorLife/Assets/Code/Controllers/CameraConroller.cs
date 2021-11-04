using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraConroller : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Vector3 _offset;
    [SerializeField] private float _pitch=2f;
    [SerializeField] private float _zoomSpeed=2f;
    [SerializeField] private float _minZoom=5f;
    [SerializeField] private float _maxZoom=15f;
    [SerializeField] private float _rotateSpeed=100f;
    private float _currentZoom = 10f;
    private float _currentRotate = 0f;

    private void Update()
    {
        _currentZoom -= Input.GetAxis("Mouse ScrollWheel") * _zoomSpeed;
        _currentZoom = Mathf.Clamp(_currentZoom, _minZoom, _maxZoom);
        _currentRotate -= Input.GetAxis("Horizontal") * _rotateSpeed * Time.deltaTime;
    }

    private void LateUpdate()
    {
        transform.position = _target.position - _offset * _currentZoom;
        transform.LookAt(_target.position+Vector3.up*_pitch);
        transform.RotateAround(_target.position,Vector3.up, _currentRotate);
    }
}
