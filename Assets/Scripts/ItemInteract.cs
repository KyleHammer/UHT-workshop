using System.Collections;
using System.Collections.Generic;
using BaseScriptableObjects;
using UnityEngine;

public class ItemInteract : MonoBehaviour
{
    [SerializeField] private GameEvent collectEvent;    
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            collectEvent.Raise();
        }
    }
}
