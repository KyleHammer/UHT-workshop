using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugLogScript : MonoBehaviour
{
    [Tooltip("Input your message below!")] [TextArea(1, 5)] [SerializeField] private string message;
    
    public void PlayDebugMessage()
    {
        Debug.Log(message);
    }
}
