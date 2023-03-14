using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Vector2 startPos;
    public bool isMovingHorizontally;
    public bool isXUsingCosine;
    public float xAmp;
    public float xPer;
    public bool isMovingVertically;
    public bool isYUsingCosine;
    public float yAmp;
    public float yPer;
    public float xPos;
    public float yPos;
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isMovingHorizontally)
        {
            if (isXUsingCosine)
            {
                float b = 6.28f / xPer;
                xPos = startPos.x + xAmp * Mathf.Cos(b * Time.time);
            }
            else
            {
                float b = 6.28f / xPer;
                xPos = startPos.x + xAmp * Mathf.Sin(b * Time.time);
            }
        }
        else
        {
            xPos = transform.position.x;
        }
        if (isMovingVertically)
        {
            if (isYUsingCosine)
            {
                float b = 6.28f / yPer;
                yPos = startPos.y + yAmp * Mathf.Cos(b * Time.time);
            }
            else
            {
                float b = 6.28f / yPer;
                yPos = startPos.y + yAmp * Mathf.Sin(b * Time.time);
            }
        }
        else
        {
            yPos = transform.position.y;
        }
        transform.position = new Vector2(xPos, yPos);
    }
}
