using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControlePoissonAxeRotation : MonoBehaviour
{
    private Rigidbody _rb;
    float angle = 0f;
    
    Vector2 direction;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void OnTourner(InputValue valeur)
    {
        angle = valeur.Get<float>();
    }

    void OnBouger(InputValue delta)
    {
        direction = delta.Get<Vector2>();
    }


    private void FixedUpdate()
    {
        _rb.AddRelativeTorque(0, angle, 0, ForceMode.VelocityChange);
        _rb.AddRelativeForce(direction.x, 0, direction.y, ForceMode.VelocityChange);
    }
}
