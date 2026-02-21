using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore;

[RequireComponent(typeof(Animator))]
public class OpenTheDoor : MonoBehaviour
{
    public string animString = "ToOpen";
    public Animator animator;

    private bool playerOnCollider;
    void Start()
    {
        if (animator == null) animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("OpenTheDoor::OpenTheDoor(); -- other:" + other);
        if (other.CompareTag("Player"))
        {
            playerOnCollider = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerOnCollider = false;
        }
    }
    // Update is called once per framesss
    void Update()
    {
        if (playerOnCollider == true)
        {
            Debug.Log("OpenTheDoor::Update(); -- Input.GetKeyDown(KeyCode.E):" + Input.GetKeyDown(KeyCode.E));
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("OpenTheDoor::Update(); -- animator:" + animator);
                animator.SetTrigger(animString);
            }
        }
    }
}
