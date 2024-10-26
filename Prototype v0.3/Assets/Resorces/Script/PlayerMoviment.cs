using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    Animator playerAnimator;
    Rigidbody rigidBody;
    public float maxPlayerSpeed, playerMovimentAceleration, playerMovimentDesaceleration;
    float startMaxPlayerSpeed, playerSpeed, acelerationTime;

    void Start()
    {
        playerAnimator = GetComponent<Animator>();
        startMaxPlayerSpeed = maxPlayerSpeed;
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        playerSpeed = playerMovimentAceleration * acelerationTime;
        if (Input.GetKey(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            acelerationTime += Time.deltaTime;
        }
        else if (playerSpeed > 0)
        {
            acelerationTime = 0;
        }
        playerSpeed = Mathf.Clamp(playerSpeed, 0, maxPlayerSpeed);

        playerAnimator.SetFloat("MovimentState", playerSpeed / maxPlayerSpeed);


        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }
    }
}
