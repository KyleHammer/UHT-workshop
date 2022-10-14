using System;
using System.Collections;
using System.Collections.Generic;
using BaseScriptableObjects;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] private GameEvent goalReached;

    private void OnTriggerEnter2D(Collider2D col)
    {
        goalReached.Raise();
    }
}
