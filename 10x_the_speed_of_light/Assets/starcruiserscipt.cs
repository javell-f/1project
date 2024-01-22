using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starcruiserscipt : MonoBehaviour
{
    public float moveSpeed = 5f;
    private bool playerCanMove = true;

    void Start()
    {
        
        Invoke("RestrictPlayerMovement", 12f);
    }

    void Update()
    {
        if (playerCanMove)
        {
            float verticalInput = Input.GetAxis("Vertical") + GetWAndSInput();

            Vector3 newPosition = transform.position + new Vector3(0f, verticalInput * moveSpeed * Time.deltaTime, 0f);

            transform.position = newPosition;
        }
    }

    float GetWAndSInput()
    {
        float wInput = Input.GetKey("w") ? 1f : 0f;
        float sInput = Input.GetKey("s") ? -1f : 0f;

        return wInput + sInput;
    }

    void RestrictPlayerMovement()
    {
        
        playerCanMove = false;

        
        Debug.Log("Player movement restricted. Display your message here.");
    }

}
