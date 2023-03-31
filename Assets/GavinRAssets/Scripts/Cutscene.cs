using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Cutscene : MonoBehaviour
{
    public Image cutsceneImage;
    public Sprite[] cutsceneSprites;
    public float timeBetweenImages = 3.0f;

    private int currentImageIndex = 0;
    private float timeSinceLastImage = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        cutsceneImage.sprite = cutsceneSprites[currentImageIndex];
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastImage += Time.deltaTime;

        if (timeSinceLastImage >= timeBetweenImages)
        {
            timeSinceLastImage = 0.0f;
            currentImageIndex++;

            if (currentImageIndex >= cutsceneSprites.Length)
            {
                // End of cutscene
                gameObject.SetActive(false);
                return;
            }

            cutsceneImage.sprite = cutsceneSprites[currentImageIndex];
            
            if (currentImageIndex == 1)
            {
                timeBetweenImages = 0.2f;
            }
            
            if (currentImageIndex == 11)
            {
                timeBetweenImages = 3.0f;
            }
        }
    }
}
