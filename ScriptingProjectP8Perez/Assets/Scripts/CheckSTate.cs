using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSTate : MonoBehaviour

{ public GameObject myObject;

 
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Active Self" + myObject.activeSelf);
        Debug.Log("Active in Hierarchy" + myObject.activeInHierarchy);
    }
}
