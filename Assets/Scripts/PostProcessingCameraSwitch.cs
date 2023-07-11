using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PostProcessingCameraSwitch : MonoBehaviour
{
    [SerializeField]
    private GameObject _camera1;

    [SerializeField]
    private bool _camera1Disabled;

    // Start is called before the first frame update
    void Start()
    {
        _camera1 = GameObject.Find("VC1");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (_camera1Disabled == false)
            {
                _camera1.SetActive(false);
                _camera1Disabled = true;
            }
            else if (_camera1Disabled == true)
            {
                _camera1.SetActive(true);
                _camera1Disabled = false;
            }
        }
    }
}
