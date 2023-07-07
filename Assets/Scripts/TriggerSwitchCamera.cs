using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class TriggerSwitchCamera : MonoBehaviour
{
    [SerializeField]
    private CinemachineVirtualCamera[] _cameras;

    [SerializeField]
    private int _triggerID;

    // Start is called before the first frame update
    void Start()
    {
        _triggerID = -1;
    }

    // Update is called once per frame
    void Update()
    {
        CheckID();
    }

    private void CheckID()
    {
        switch (_triggerID)
        {
            case 0:
                _cameras[1].Priority = 12;
                Debug.Log("Switch to High Elevation");
                break;
            case 1:
                _cameras[2].Priority = 13;
                Debug.Log("Switch to Tracked Dolly");
                break;
            case 2:
                _cameras[3].Priority = 14;
                Debug.Log("Switch to Aim");
                break;
            case 3:
                Debug.Log("Switch to 3rd Person");
                _cameras[0].Priority = 11;
                _cameras[1].Priority = 10;
                _cameras[2].Priority = 10;
                _cameras[3].Priority = 10;
                break;
        }
    }

    public void GetTriggerID(int ID)
    {
        _triggerID = ID;
    }
}
