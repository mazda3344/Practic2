using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore;

[RequireComponent(typeof(Animator))]
public class OpenTheDoor : MonoBehaviour
{
    public Animator animator;
    public Animation OpenDoor;

    void Start()
    {
        if (animator == null) animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetTrigger("ToOpen");
        }
    }
}
