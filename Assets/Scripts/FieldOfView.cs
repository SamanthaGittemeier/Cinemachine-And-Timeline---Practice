using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class FieldOfView : MonoBehaviour
{
    [SerializeField]
    private CinemachineVirtualCamera _cam;

    [SerializeField]
    private GameObject _cube;
    [SerializeField]
    private GameObject _sphere;

    // Start is called before the first frame update
    void Start()
    {
        _cube = GameObject.Find("Cube");
        _sphere = GameObject.Find("Sphere");
        _cam = GetComponent<CinemachineVirtualCamera>();
        _cam.m_Lens.FieldOfView = 60;
        _cam.LookAt = _cube.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Zoom();
        SwitchTarget();
    }

    private void Zoom()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_cam.m_Lens.FieldOfView == 20)
            {
                _cam.m_Lens.FieldOfView = 60;
            }
            else
            {
                _cam.m_Lens.FieldOfView -= 20;
            }
        }
    }

    private void SwitchTarget()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (_cam.LookAt == _cube.transform)
            {
                _cam.LookAt = _sphere.transform;
            }
            else if (_cam.LookAt == _sphere.transform)
            {
                _cam.LookAt = _cube.transform;
            }
        }
    }
}
