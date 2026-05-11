using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  

public class Collect : MonoBehaviour
{
    private Animator animator;
    public GameObject Cay;
    public TextMeshProUGUI Coin;
    private int score = 0;


    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetTrigger("Collect");
            Destroy (Cay, 0.3f );
        }
    }

}
