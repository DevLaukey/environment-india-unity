using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class triggerZone : MonoBehaviour
{
    public string targetTag;
    public UnityEvent<GameObject> onEnterEvent;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == targetTag)
        {
            onEnterEvent.Invoke(other.gameObject);
        }
    }

}
