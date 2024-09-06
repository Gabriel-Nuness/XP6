using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Building : MonoBehaviour
{
    public Transform playerTransform;
    Transform parent;

    private void Start()
    {
        //parent = transform.parent;
    }

    void Update()
    {
        if (playerTransform != null)
        {
            Vector3 direction = new Vector3(transform.position.x - playerTransform.position.x, 0, transform.position.z - playerTransform.position.z);
            Debug.Log(direction);
            Vector3 currentRotation = transform.eulerAngles;
            transform.rotation = Quaternion.Euler(currentRotation + (-.01f * direction));

            Debug.DrawLine(transform.position, playerTransform.position, Color.red);
            Debug.Log("Player");
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.CompareTag("Player")) playerTransform = collision.transform;
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.transform.CompareTag("Player")) playerTransform = null;
    }
}
