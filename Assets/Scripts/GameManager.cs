using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour


{
    public bool _isGameOver = false;
    public int _ballCount = 6;
    public int _pinCount = 10;
    public int _currentFrame = 0;
    public int _currentBall = 0;
    public bool _isFrameOver = false;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ResetBalls();
        ResetPins();
    }

    void ResetBalls()
    {
        if (_ballCount < 1)
        {
            //instantiate new set of balls
            //Debug.Log("Out of Balls");

        }
    }

    void ResetPins()
    {
        if (_pinCount < 1 | _isFrameOver)
        {
            //instantiate new set of pins
            Debug.Log("All Pins Down");
        }
    }

    void StartGame()
    { 
    
    }

    void GameOver()
    {


    }


}
