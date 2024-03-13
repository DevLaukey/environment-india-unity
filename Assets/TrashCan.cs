using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCan : MonoBehaviour
{
    private void Start()
    {
        GetComponent<triggerZone>().onEnterEvent.AddListener(insideTrashCan);
    }

    public void insideTrashCan(GameObject go)
    {
        go.SetActive(false);
    }
}
