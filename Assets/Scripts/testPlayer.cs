using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class testPlayer : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 1.0f;
    Vector2 momentVector;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }
    void OnMove(InputValue momentValue)
    {
        momentVector = momentValue.Get<Vector2>();
        momentVector *= speed;

        

    }

    private void FixedUpdate()
    {

        rb.AddForce(momentVector.x, 0.0f, momentVector.y);

    }
}
