using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boy : MonoBehaviour
{
    [SerializeField] private Transform spawnAttack;
    [SerializeField] private GameObject attackObject;
    [SerializeField] private GameObject pause;
    private CharacterController controller;
    private float playerSpeed = 35f;
    private Animator _animator;

    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
        _animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (Input.GetKeyDown("space"))
        {
            _animator.SetTrigger("Attack");
            Throw();
        }

        if (Input.GetKeyDown("a"))
        {
            Debug.Log ("A");
            _animator.SetTrigger("StrafeLeft");
            _animator.ResetTrigger("StrafeRight");
        }

        if (Input.GetKeyDown("d"))
        {
            _animator.SetTrigger("StrafeRight");
            _animator.ResetTrigger("StrafeLeft");
        }

         if (Input.GetKeyDown("escape"))
        {
            Pause();
        }
    }

    private void Throw ()
    {
        Quaternion forward = Quaternion.LookRotation(transform.forward);
        GameObject attack = Instantiate (attackObject, spawnAttack.position, forward);
        attack.GetComponent<Rigidbody>().velocity = transform.forward * 300f;
        Destroy(attack, 3f);
    }

    private void Pause()
    {
        // Time.timeScale = 0;
        // pause.SetActive = true;
    }
}