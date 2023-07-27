using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightbulbChallenge : MonoBehaviour
{
    [SerializeField]
    private GameObject _lightbulbTimeline;

    // Start is called before the first frame update
    void Start()
    {
        _lightbulbTimeline = GameObject.Find("Timeline_BulbChallenge");
        _lightbulbTimeline.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            _lightbulbTimeline.SetActive(true);
        }
    }
}
