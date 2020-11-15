using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBall : MonoBehaviour
{
    private Vector3 startPOS; //record balls starting position
    //private float xMin = -1.85f;//difference between start position and left edge of lane
    //private float xMax = 10.85f;//.3f;//difference between start position and right edge of lane
    private float yMin = -0.10f;
    private float yMax = 4f;
    private float zMin = -2.5f; 
    private float zMax = 70f;
    //public int _ballCount = 0;

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
        bool bminz = transform.position.z < zMin;
        bool bmaxz = transform.position.z > zMax;
        bool bminy = transform.position.y < yMin;
        bool bmaxy = transform.position.y > yMax;
        //bool bminx = transform.position.x < startPOS.x + xMin;
        //bool bmaxx = transform.position.x > startPOS.x + xMax;

        if (bminy|bmaxy|bminz|bmaxz)
        {
            gameManager._ballCount--;
             

            Debug.Log(transform.position + 
                "xmin:"+0 + "/xmax:" + 0 + 
                ";ymin:" + bminy + "/ymax:" + bmaxy + 
                ";zmin:" + bminz + "/zmax:" + bmaxz);

            Destroy(gameObject);
            //transform.position = startPOS;
            
        }
    }
}
