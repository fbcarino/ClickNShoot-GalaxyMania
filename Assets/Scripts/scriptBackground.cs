using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptBackground : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time) * 0.005f + transform.position.x,
            transform.position.y, transform.position.z);       //allows background to sway left and right.
    }
}
