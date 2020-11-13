using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBall : MonoBehaviour
{
    private Vector3 startPOS;
    private float xMin = -3.5f;//difference between start position and left edge of lane
    private float xMax = .3f;//difference between start position and right edge of lane
    private float yMin = .25f;
    private float yMax = 4f;
    private float zMin = 2.5f; 
    private float zMax = 18.9f;

    public GameManager gameManager;

    

    private void Awake()
    {
        startPOS = transform.position;
        Debug.Log(transform.position + transform.name);
    }
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        outOfBounds();
    }

    void outOfBounds()
    {
        if (transform.position.z < zMin | transform.position.z > zMax |
            transform.position.y < yMin | transform.position.y > yMax |
            transform.position.x < startPOS.x + xMin | transform.position.x > startPOS.x + xMax)
        {
            Debug.Log("moved " + transform.name + " to startPOS from " + transform.position);
            gameManager._ballCount--;
            GameObject.Destroy(this);
            //transform.position = startPOS;
            
        }
    }
}
