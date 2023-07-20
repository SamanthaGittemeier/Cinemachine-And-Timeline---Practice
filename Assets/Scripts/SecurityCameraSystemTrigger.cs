using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class SecurityCameraSystemTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _securityCameras;

    [SerializeField]
    private int _cameraSwitch;

    void Start()
    {
       TurnOffSecurityCameras();
        _cameraSwitch = 0;
    }

    void Update()
    {
        CycleSecurityCameras();
    }

    private void CycleSecurityCameras()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            _securityCameras[_cameraSwitch].SetActive(false);
            _cameraSwitch++;
            if (_cameraSwitch >= 3)
            {
                TurnOnSecurityCameras();
                _cameraSwitch = 0;
            }
        }
    }

    private void TurnOffSecurityCameras()
    {
        foreach (GameObject _sc in _securityCameras)
        {
            _sc.gameObject.SetActive(false);
            Debug.Log("Security Camera Turned Off");
        }
    }

    private void TurnOnSecurityCameras()
    {
        foreach (GameObject _sc in _securityCameras)
        {
            _sc.gameObject.SetActive(true);
            Debug.Log("Security Camera Turned On");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            TurnOnSecurityCameras();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            TurnOffSecurityCameras();
        }
    }
}
