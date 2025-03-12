using UnityEngine;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class AxisRawExample : MonoBehaviour
{
    public float range;
    //Start is called before trhe first frame update
    private void Start()
    {
        
    }



    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float xPos = h * range;

        transform.position = new Vector3(xPos, 1f, 0);
        Debug.Log("Value Returned: " + h.ToString("F2"));

    }
}
