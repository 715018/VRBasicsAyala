using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleRotation : MonoBehaviour
{
    public float rotationSpeed = 45.0f; // Adjust the rotation speed as needed

    void Update()
    {
        // Rotate the object around its Y-axis
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
