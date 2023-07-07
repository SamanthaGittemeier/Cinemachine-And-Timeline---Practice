using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamSwitch : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _cameras;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SwitchToOrbital();
    }

    private void SwitchToOrbital()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            _cameras[0].SetActive(false);
        }
        else if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            _cameras[0].SetActive(true);
        }
    }
}
