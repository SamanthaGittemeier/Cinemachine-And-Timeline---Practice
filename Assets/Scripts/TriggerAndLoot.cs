using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerAndLoot : MonoBehaviour
{
    [SerializeField]
    private GameObject _director;
    [SerializeField]
    private GameObject _particleEffect;
    [SerializeField]
    private GameObject[] _diamonds;

    // Start is called before the first frame update
    void Start()
    {
        _director = GameObject.Find("TreasureChestTimeline");
        _director.SetActive(false);
        _particleEffect = GameObject.Find("Particle System");
        _particleEffect.SetActive(false);
        _diamonds = GameObject.FindGameObjectsWithTag("Diamond");
        HideLoot();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _director.SetActive(true);
        }
    }

    public void HideLoot()
    {
        foreach (GameObject d in _diamonds)
        {
            d.SetActive(false);
        }
    }
}
