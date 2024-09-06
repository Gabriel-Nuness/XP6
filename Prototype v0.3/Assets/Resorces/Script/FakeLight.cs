using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeLight : MonoBehaviour
{
    public GameObject fakeLight, enemy;

    private void Start()
    {
        fakeLight.SetActive(true);
        enemy.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            fakeLight.SetActive(false);
            enemy.SetActive(true);
        }
    }
}
