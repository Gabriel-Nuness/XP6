using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Splines;

public class CameraMoviment : MonoBehaviour
{
    Transform playerTransform;
    Vector3 currentVelocity, movePosition;
    public bool canMoveX, canMoveZ;
    public Transform pivot; 

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (Mathf.Abs(transform.position.x - playerTransform.position.x) > 7f) canMoveX = true;
        if (Mathf.Abs(transform.position.z - playerTransform.position.z) > 7f) canMoveZ = true;
        if (Vector3.Distance(transform.position, playerTransform.position) <= 1.5f)
        {
            canMoveX = false;
            canMoveZ = false;
        }
        if (canMoveX)
        {
            movePosition = new Vector3(playerTransform.position.x, playerTransform.position.y, transform.position.z);
            transform.position = Vector3.SmoothDamp(transform.position, movePosition, ref currentVelocity, .5f, Mathf.Infinity, Time.deltaTime);
        }
        if (canMoveZ)
        {
            movePosition = new Vector3(transform.position.x, playerTransform.position.y, playerTransform.position.z);
            transform.position = Vector3.SmoothDamp(transform.position, movePosition, ref currentVelocity, .5f, Mathf.Infinity, Time.deltaTime);
        }
    }
}
