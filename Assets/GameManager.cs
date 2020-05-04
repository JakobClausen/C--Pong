using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Ball Ball;
    public Paddle Paddle;
    public static Vector2 bottomLeft;
    public static Vector2 topRight;
    
    // Start is called before the first frame update
    void Start()
    {
        // Converts the pixels to game coordinate
        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        
        // Create Ball
        Instantiate(Ball);
        
        // create to paddles
        Paddle paddle1 =Instantiate(Paddle) as Paddle;
        Paddle paddle2 = Instantiate(Paddle) as Paddle;
        paddle1.Init(true); // right Paddle
        paddle2.Init(false); // right Paddle

    }
    
}
