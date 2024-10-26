using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEditor;
using UnityEngine;
using UnityEngine.ProBuilder.MeshOperations;

public class Light : MonoBehaviour
{
    public LayerMask layer;
    public float smoothTime, screenHightRatio = 6.5f;
    float startY;
    Vector3 currentVelocity;
    Camera cam;

    private void Start()
    {
        cam = Camera.main;
        startY = transform.position.y;
    }

    void Update()
    {
        Vector3 mouseScreenPositin = Input.mousePosition;
        Ray mouseRay = cam.ScreenPointToRay(mouseScreenPositin - new Vector3(0, screenHightRatio));

        if (Physics.Raycast(mouseRay, out RaycastHit hit, layer))
        {
            Vector3 mousePosition = hit.point;
            mousePosition.y = startY;
            //transform.position = mousePosition;
            transform.position = Vector3.SmoothDamp(transform.position, mousePosition, ref currentVelocity, smoothTime, Mathf.Infinity, Time.deltaTime);
        }
    }
}
