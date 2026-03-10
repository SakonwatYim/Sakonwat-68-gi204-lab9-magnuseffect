using UnityEngine;
using UnityEngine.InputSystem;

public class TorqueRotate : MonoBehaviour
{
    Rigidbody rb;
    float TorquePower = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        if(Keyboard.current.dKey.isPressed)
        {
            ApplyTorque();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ApplyTorque()
    {
        Vector3 forceDirection = new Vector3(TorquePower,0,0);
        Vector3 pivotPoint = new Vector3(0, 0, 1);
        Vector3.Cross(forceDirection, pivotPoint);
    }
}
