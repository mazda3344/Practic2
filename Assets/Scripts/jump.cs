using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public float jumpForce = 5f; // Сила прыжка
    public int maxJumps = 2; // Максимальное количество прыжков (2 для двойного)
    
    private Rigidbody rb;
    private int jumpsLeft;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jumpsLeft = maxJumps;
    }

    void Update()
    {
        // Проверка нажатия кнопки прыжка
        if (Input.GetButtonDown("Jump") && jumpsLeft > 0)
        {
            // Обнуляем текущую вертикальную скорость для стабильности прыжка
            rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
            
            // Прикладываем силу вверх
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            
            jumpsLeft--; // Уменьшаем количество оставшихся прыжков
        }
    }

    // Проверка касания земли
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            jumpsLeft = maxJumps; // Сбрасываем прыжки при касании земли
        }
    }
}
