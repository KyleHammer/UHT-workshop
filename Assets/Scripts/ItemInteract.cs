using System;
using System.Collections;
using System.Collections.Generic;
using BaseScriptableObjects;
using Unity.VisualScripting;
using UnityEngine;

public class ItemInteract : MonoBehaviour
{
    [SerializeField] private GameEvent collectEvent;
    [SerializeField] private bool deleteOnPickup = false;
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if(deleteOnPickup)
                Destroy(gameObject);

            try
            {
                collectEvent.Raise();
            }
            catch (NullReferenceException e)
            {
                
            }
        }
    }
}
