using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _virtualCam1;
    [SerializeField]
    private GameObject _virtualCam2;
    [SerializeField]
    private GameObject _virtualCam3;

    [SerializeField]
    private bool _cam1And2Disabled;

    void Start()
    {
        _virtualCam1 = GameObject.Find("VC1");
        _virtualCam2 = GameObject.Find("VC2");
        _virtualCam3 = GameObject.Find("VC3");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (_cam1And2Disabled == false)
            {
                _virtualCam1.SetActive(false);
                _virtualCam2.SetActive(false);
                _cam1And2Disabled = true;
            }
            else if (_cam1And2Disabled == true)
            {
                _virtualCam1.SetActive(true);
                _virtualCam2.SetActive(true);
                _cam1And2Disabled = false;
            }
        }
    }
}
