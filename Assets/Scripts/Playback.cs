using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Playback : MonoBehaviour
{
    [SerializeField]
    private PlayableDirector _director;

    [SerializeField]
    private float _advanceTime;

    // Start is called before the first frame update
    void Start()
    {
        _director = GetComponent<PlayableDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            _director.Play();
            Debug.Log("Played Timeline");
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            _director.time = _advanceTime;
            Debug.Log("Skipped to 5 seconds");
        }
    }

    public void PauseTimeline()
    {
        _director.Pause();
    }
}
