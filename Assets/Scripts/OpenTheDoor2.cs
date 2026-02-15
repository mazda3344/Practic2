using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTheDoor2 : MonoBehaviour
{
    public Animator animator;
    
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
