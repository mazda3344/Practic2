using UnityEngine;

public class ForcePushDoor1 : MonoBehaviour
{
    public Rigidbody rb;
    public float pushForce = 5000000f; // Регулируемая сила толчка
    public KeyCode pushButtonKey = KeyCode.A;
    public ForceMode forceMode = ForceMode.VelocityChange;

    public Vector3 vector3 = Vector3.back;

    void Start()
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody>();
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(pushButtonKey))
        {
            PushDoor();
        }
    }

    // Эта публичная функция вызывается кнопкой в UI
    public void PushDoor()
    {
        // Применяем вращающий момент (крутящий момент), чтобы открыть/закрыть дверь
        // Ось Y обычно является осью вращения для HingeJoint (проверьте в инспекторе)
        rb.AddTorque(vector3 * pushForce, forceMode);
    }
}
