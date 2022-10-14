using System;
using BaseScriptableObjects;
using UnityEngine;

public class OnStart : MonoBehaviour
{
    [SerializeField] private GameEvent startEvent;
    
    private void Start()
    {
        try
        {
            startEvent.Raise();
        }
        catch (NullReferenceException e)
        {
                
        }
    }
}
