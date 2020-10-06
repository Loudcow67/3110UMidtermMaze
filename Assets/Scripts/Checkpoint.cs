using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    [SerializeField]
    private Transform checkpoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.transform.position = checkpoint.transform.position;
            Physics.SyncTransforms();
        }
    }
}
