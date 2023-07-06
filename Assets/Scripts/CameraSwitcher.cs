using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _virtualCameras;

    [SerializeField]
    private int _camNumber;

    // Start is called before the first frame update
    void Start()
    {
        _camNumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        SwitchCameras();
    }

    private void SwitchCameras()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (_camNumber <= 2)
            {
                _virtualCameras[_camNumber].SetActive(false);
                _camNumber++;
            }
            else if (_camNumber == 3)
            {
                _virtualCameras[0].SetActive(true);
                _virtualCameras[1].SetActive(true);
                _virtualCameras[2].SetActive(true);
                _camNumber = 0;
            }
        }
    }
}
