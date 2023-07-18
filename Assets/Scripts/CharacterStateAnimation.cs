using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterStateAnimation : MonoBehaviour
{
    [SerializeField]
    private Animator _characterAnim;

    void Start()
    {
        _characterAnim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        Die();
        Aim();
    }

    private void Die()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _characterAnim.SetTrigger("IsDead");
        }
    }

    private void Aim()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            _characterAnim.SetBool("IsAiming", true);
        }
        else if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            _characterAnim.SetBool("IsAiming", false);
        }
    }
}
