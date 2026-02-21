using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void OiggerEnter(Collider other)
    {
        anim.SetBool("Alive", false);
        anim.SetTrigger("collect");
    }
    public void DestroySomething()
    {
        Destroy(FindObjectOfType<MeshFilter>().gameObject);
    }
}
