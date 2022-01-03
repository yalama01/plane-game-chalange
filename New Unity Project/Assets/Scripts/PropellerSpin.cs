using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    Vector3 rotation = new Vector3(0, 0, 10);

    float rotationSpeed = 10f;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(rotation * rotationSpeed);
    }
}
