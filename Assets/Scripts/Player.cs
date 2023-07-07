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

    [SerializeField]
    private int _iD;

    [SerializeField]
    private GameObject[] _triggers;


    // Start is called before the first frame update
    void Start()
    {
        _iD = -1;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        ResetID();
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

    private void ResetID()
    {
        if (_iD == 3)
        {
            _iD = -1;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Trigger")
        {
            _iD++;
            foreach (GameObject trigger in _triggers)
            {
                other.GetComponent<TriggerSwitchCamera>().GetTriggerID(_iD);
            }
        }
    }
}
