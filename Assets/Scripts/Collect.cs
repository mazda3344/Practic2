using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using TMPro;  

public class Collect : MonoBehaviour
{
    private Animator animator;
<<<<<<< HEAD
    public GameObject Cay;
    public TextMeshProUGUI Coin;
    private int score = 0;


=======
    public float destroyDelay = 2.0f;
    public GameObject Effect;

>>>>>>> dd9de9c64473e7a76a6005c44416abf768395e3a
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
<<<<<<< HEAD
        if (other.CompareTag("Player"))
        {
            animator.SetTrigger("Collect");
            Destroy (Cay, 0.3f );
=======
        if (other.CompareTag("Player")) 
        {
            animator.SetTrigger("Collect");
            Destroy(gameObject, destroyDelay); 
            Destroy(Effect, destroyDelay);
>>>>>>> dd9de9c64473e7a76a6005c44416abf768395e3a
        }
    }

}
