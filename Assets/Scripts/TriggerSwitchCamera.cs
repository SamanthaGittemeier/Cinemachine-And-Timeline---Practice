using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class TriggerSwitchCamera : MonoBehaviour
{
    [SerializeField]
    private CinemachineVirtualCamera[] _cameras;

    [SerializeField]
    private CinemachineVirtualCamera _assignedCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetAllCams()
    {
        foreach (CinemachineVirtualCamera c in _cameras)
        {
            c.GetComponent<CinemachineVirtualCamera>().Priority = 10;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if (_assignedCamera != null)
            {
                ResetAllCams();
                _assignedCamera.Priority = 11;
            }
        }
    }
}
