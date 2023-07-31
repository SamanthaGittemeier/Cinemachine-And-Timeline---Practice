using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneChallenge : MonoBehaviour
{
    [SerializeField]
    private GameObject _cutsceneDirector;

    // Start is called before the first frame update
    void Start()
    {
        _cutsceneDirector = GameObject.Find("CutsceneTimeline");
        _cutsceneDirector.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        _cutsceneDirector.SetActive(true);
    }
}
