using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour


{
    public bool _isGameOver = false;
    public int _ballCount = 0;
    public int _pinCount = 80;
    public int _currentFrame = 0;
    public int _currentBall = 0;
    public bool _isFrameOver = false;

    public GameObject ball;
    private Vector3 ball1POS = new Vector3(0.9f, 1.5f, -0.1f);
    private Vector3 ball2POS = new Vector3(0.9f, 1.5f, 0.2f);
    private Vector3 ball3POS = new Vector3(0.9f, 1.5f, 0.5f);
    //private BowlingBall bbScript;
    

    // Start is called before the first frame update
    void Start()
    {
        //bbScript = GetComponent<BowlingBall>();
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
            Instantiate(ball, ball1POS, Quaternion.Euler(0, 0, 0));
            Instantiate(ball, ball2POS, Quaternion.Euler(0, 0, 0));
            Instantiate(ball, ball3POS, Quaternion.Euler(0, 0, 0));
            _ballCount = 3;
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
