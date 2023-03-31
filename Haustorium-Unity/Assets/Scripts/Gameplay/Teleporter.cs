using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    [SerializeField] GameObject TeleportDestination;
    [SerializeField] GameObject player;

    public void Start()
    {
        if(player == null)
        {
            player = PlayerManager.Instance.Player.gameObject;
        }
    }
    public void Teleport()
    {
        print("Attempting to teleport player.");
        player.transform.position = TeleportDestination.transform.position;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player = other.gameObject;
            Teleport();
        }
    }
}
