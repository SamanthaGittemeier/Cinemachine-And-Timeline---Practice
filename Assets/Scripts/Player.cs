using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] 
    private CharacterController _controller;

    [SerializeField] 
    private float _moveSpeed;
    [SerializeField] 
    private float _rotateSpeed;

    private Vector3 _direction;

    void Start()
    {
        
    }

    void Update()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        float _horizontal = Input.GetAxis("Horizontal");
        float _vertical = Input.GetAxis("Vertical");
        _direction = new Vector3(0, 0, _vertical);
        _direction *= _moveSpeed * Time.deltaTime;
        _controller.Move(_direction);

        Vector3 rotation = new Vector3(0, _horizontal * _rotateSpeed * Time.deltaTime, 0);
        this.transform.Rotate(rotation);
    }
}
