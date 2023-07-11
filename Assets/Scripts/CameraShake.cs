using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraShake : MonoBehaviour
{
    [SerializeField]
    private CinemachineImpulseSource _impulseSource;

    // Start is called before the first frame update
    void Start()
    {
        _impulseSource = gameObject.GetComponent<CinemachineImpulseSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shake();
        }
    }

    private void Shake()
    {
        _impulseSource.GenerateImpulse();
    }
}
