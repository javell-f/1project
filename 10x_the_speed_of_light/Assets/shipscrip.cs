using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Script : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical") + GetWAndSInput();

        Vector3 newPosition = transform.position + new Vector3(0f, verticalInput * moveSpeed * Time.deltaTime, 0f);

        transform.position = newPosition;
    }

    float GetWAndSInput()
    {
        float wInput = Input.GetKey("w") ? 1f : 0f;
        float sInput = Input.GetKey("s") ? -1f : 0f;

        return wInput + sInput;
    }
}