using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Declare game variables to view in inspector
    public bool _isGameOver = false;
    public int _ballCount = 0;
    public int _pinCount = 80;
    public int _currentFrame = 0;
    public int _currentBall = 0;
    public bool _isFrameOver = false;

    //Declare game variables to set in inspector
    public GameObject ball;

    //Starting position of our three balls used to instantiage new balls
    private Vector3 ball1POS = new Vector3(0.9f, 1.5f, -0.1f);
    private Vector3 ball2POS = new Vector3(0.9f, 1.5f, 0.2f);
    private Vector3 ball3POS = new Vector3(0.9f, 1.5f, 0.5f);
   
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

    void ResetBalls() //if we are out of balls all 3 more
    {
        if (_ballCount < 1)
        {
            //instantiate new set of balls
            Instantiate(ball, ball1POS, Quaternion.Euler(0, 0, 0));
            Instantiate(ball, ball2POS, Quaternion.Euler(0, 0, 0));
            Instantiate(ball, ball3POS, Quaternion.Euler(0, 0, 0));
            _ballCount = 3; //reset the ball count to 3
        }
    }

    void ResetPins() //If all pins are down, level cleared reset pins
    {
        if (_pinCount < 1 | _isFrameOver)  //not using frameover as this is ot a traditional bowling game
        {
            //instantiate new set of pins

        }
    }

    void StartGame()
    { 
    
    }

    void GameOver()
    {


    }


}
