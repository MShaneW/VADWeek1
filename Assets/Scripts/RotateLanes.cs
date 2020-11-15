using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLanes : MonoBehaviour
{
    public float laneRotationSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 1 * laneRotationSpeed * Time.deltaTime, 0);
    }
}
