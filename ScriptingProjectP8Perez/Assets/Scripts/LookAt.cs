using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class LookAt : MonoBehaviour
{
    public Transform target;  
    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);

    }
}
