using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BACKGROUND : MonoBehaviour
{
    public SpriteRenderer Background;
    public Sprite F0, F1, F2, F3, F4, F5, F6, F7;
    public int frame = 0;
    public float time = 0;

    public int lastFrame = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;


        if (time >= 0.2f)
        {
            //check if call a new frame
            if (frame == lastFrame)
            {
                //repeet untill the wanted frame is found (any frame but the last frame)
                frame = Random.Range(0, 8);
            }
            //after finding a new frame set the last frame to the same number
            lastFrame = frame;



            if (frame == 0)
            {
                Background.sprite = F0;
            }
            else if (frame == 1)
            {
                Background.sprite = F1;
            }
            else if (frame == 2)
            {
                Background.sprite = F2;
            }
            else if (frame == 3)
            {
                Background.sprite = F3;
            }
            else if (frame == 4)
            {
                Background.sprite = F4;
            }
            else if (frame == 5)
            {
                Background.sprite = F5;
            }
            else if (frame == 6)
            {
                Background.sprite = F6;
            }
            else if (frame == 7)
            {
                Background.sprite = F7;
            }

            time = 0;
        }


    }

}
