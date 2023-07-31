using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinematicCutsceneChallenge : MonoBehaviour
{
    [SerializeField]
    private GameObject _cinematicCutsceneDirector;

    // Start is called before the first frame update
    void Start()
    {
        _cinematicCutsceneDirector = GameObject.Find("CinematicCutsceneDirector");
        _cinematicCutsceneDirector.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _cinematicCutsceneDirector.SetActive(true);
        }
    }
}
