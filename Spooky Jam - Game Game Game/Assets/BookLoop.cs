using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookLoop : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Spin the object around the world origin at 20 degrees/second.
        Vector3 point = new Vector3(28, 1, 38);
        Vector3 axis = new Vector3(0, 0, 1);
        transform.RotateAround(point, axis, Time.deltaTime * 1);
    }
}
