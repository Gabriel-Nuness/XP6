using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxVelocityWalking, maxVelocityRunning;
    float velocity;
    CharacterController controller;
    public float maxSanity, sanityDamageTaken;
    public bool isProtected;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift)) velocity = maxVelocityRunning;
        else velocity = maxVelocityWalking;

        Vector3 direction = new Vector3(Input.GetAxisRaw("Vertical"), 0, -Input.GetAxisRaw("Horizontal"));
        if (Physics.Raycast(transform.position - new Vector3(0, GetComponent<MeshFilter>().sharedMesh.bounds.extents.y, 0), -transform.up, 2f))
        {
            controller.SimpleMove(direction.normalized * velocity);
        }

        if (transform.childCount > 0)
        {
            if (transform.GetChild(0).name.Contains("Lamp")) isProtected = true;
            return;
        }
        isProtected = false;
    }
}
