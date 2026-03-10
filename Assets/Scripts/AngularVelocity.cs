using UnityEditorInternal;
using UnityEngine;
using UnityEngine.InputSystem;

public class AngularVelocity : MonoBehaviour
{
    Rigidbody rb;
    public float AngularSpeed = 5f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        if (Keyboard.current.aKey.isPressed)
        {
            rb.angularVelocity = new Vector3(0, AngularSpeed, 0);
        }
        else
        { 
            rb.angularVelocity = Vector3.zero; 
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
