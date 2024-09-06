using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.ProBuilder;

public class AgressiveShadowEnemy : MonoBehaviour
{
    public float distance, minDistanceToTheTarget, time;
    public bool sinMoviment;
    float startMinDistanceToTheTarget;
    public Vector3 velocity;
    GameObject player;
    Vector3 lockedDirection;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        startMinDistanceToTheTarget = minDistanceToTheTarget;
        rotateEnemyToStartPosition();
    }


    void Update()
    {
        transform.position += transform.forward * .01f;

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, .75f, LayerMask.GetMask("Ground")))
        {
            rotateEnemy(hit.normal);
        }
    }
    void rotateEnemy(Vector3 normal)
    {
        Vector3 arbitraryVector = new Vector3(-1, 0, 0);
        Vector3 perpendicularNormal = Vector3.Cross(normal, arbitraryVector);

        float angle = Vector3.Angle(transform.forward, perpendicularNormal);
        Debug.Log(angle);
        transform.eulerAngles -= new Vector3(angle, 0, 0);
    }

    void rotateEnemyToStartPosition()
    {
        transform.eulerAngles += new Vector3(getCurrentPosition(), 0, 0);
    }

    float getCurrentPosition()
    {
        Vector3 paralelNormal = new();
        paralelNormal = getGroundParalelNormal(transform.forward);
        if (paralelNormal.magnitude != 0)
        {
            return Vector3.Angle(transform.forward, paralelNormal);
        }
        paralelNormal = getGroundParalelNormal(-transform.forward);
        if (paralelNormal.magnitude != 0)
        {
            return Vector3.Angle(transform.forward, paralelNormal);
        }
        paralelNormal = getGroundParalelNormal(transform.right);
        if (paralelNormal.magnitude != 0)
        {
            return Vector3.Angle(transform.forward, paralelNormal);
        }
        paralelNormal = getGroundParalelNormal(-transform.right);
        if (paralelNormal.magnitude != 0)
        {
            return Vector3.Angle(transform.forward, paralelNormal);
        }
        paralelNormal = getGroundParalelNormal(transform.up);
        if (paralelNormal.magnitude != 0)
        {
            return Vector3.Angle(transform.forward, paralelNormal);
        }
        return 0;
    }

    Vector3 getGroundParalelNormal(Vector3 direction)
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, direction, out hit, .75f, LayerMask.GetMask("Ground")))
        {
            Vector3 arbitraryVector = new Vector3(-1, 0, 0);
            Vector3 perpendicularNormal = Vector3.Cross(hit.normal, arbitraryVector);
            return perpendicularNormal;
        }
        return Vector3.zero;
    }
}
