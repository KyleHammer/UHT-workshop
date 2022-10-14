using System;
using PlayerScripts;
using UnityEngine;

public class DisableMovement : MonoBehaviour
{
    private Player player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    public void StopPlayerMovement()
    {
        player.DisableMovement();
    }
}
