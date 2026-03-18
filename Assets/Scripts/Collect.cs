using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Collect : MonoBehaviour
{
    private Animator animator;
    public float destroyDelay = 2.0f;
    public GameObject Effect;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            animator.SetTrigger("Collect");
            Destroy(gameObject, destroyDelay); 
            Destroy(Effect, destroyDelay);
        }
    }
}
