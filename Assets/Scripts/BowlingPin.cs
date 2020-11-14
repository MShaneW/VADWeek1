using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingPin : MonoBehaviour
{
    public int _pinCount = 10;
    public int _pinsDown = 0;
    public bool _pinCounted = false;

    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckPins();
    }

    void CheckPins()
    {

        if (transform.up.y < 0.5 )
        {
            if (!_pinCounted)
            {
                gameManager._pinCount--;
                _pinCount--;
                _pinCounted = true;
            }
           
        }

    }
}
