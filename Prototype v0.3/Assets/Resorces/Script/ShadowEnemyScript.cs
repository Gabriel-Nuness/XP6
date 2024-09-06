using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowEnemyScript : MonoBehaviour
{
    public float maxScale;
    public bool isDynamic;
    bool decreaseSpeed, startExpand;

    private void OnEnable()
    {
        startExpand = true;
    }

    private void Update()
    {
        if (startExpand && transform.localScale.x <= maxScale)
        {
            transform.localScale += Vector3.one * maxScale / 15 * Time.deltaTime;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!other.GetComponent<Player>().isProtected)
            {
                other.GetComponent<Player>().sanityDamageTaken += 2.5f * Time.deltaTime;
                if (!decreaseSpeed)
                {
                    other.GetComponent<Player>().maxVelocityRunning -= 1.5f;
                    other.GetComponent<Player>().maxVelocityWalking -= 1.5f;
                    decreaseSpeed = true;
                }
            }
            else if (decreaseSpeed == true)
            {
                other.GetComponent<Player>().maxVelocityRunning += 1.5f;
                other.GetComponent<Player>().maxVelocityWalking += 1.5f;
                decreaseSpeed = false;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Player>().maxVelocityRunning += 1.5f;
            other.GetComponent<Player>().maxVelocityWalking += 1.5f;
            decreaseSpeed = false;
        }
    }
}
