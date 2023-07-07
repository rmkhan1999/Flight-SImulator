using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public bool st = true;
    public Text ui;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (st)
        {
            if (Input.GetKey(KeyCode.W))
            {
                ui.text = "Press (S) to move downward";
            }

            if (Input.GetKey(KeyCode.S))
            {
                if (ui.text == "Press (S) to move downward")
                {
                    ui.text = "Press (D) to move right";
                }
            }

            if (Input.GetKey(KeyCode.D))
            {
                if (ui.text == "Press (D) to move right")
                {
                    ui.text = "Press (A) to move left";
                }
            }

            if (Input.GetKey(KeyCode.A))
            {
                if (ui.text == "Press (A) to move left")
                {
                    ui.text = "Press (left arrow key) to tilt left";
                }
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (ui.text == "Press (left arrow key) to tilt left")
                {
                    ui.text = "Press (right arrow key) to tilt right";
                }
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                if (ui.text == "Press (right arrow key) to tilt right")
                {
                    ui.text = "Press (up arrow key) to tilt up";
                }
            }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                if (ui.text == "Press (up arrow key) to tilt up")
                {
                    ui.text = "Press (R) to reset the level";
                }
            }

            if (Input.GetKey(KeyCode.R))
            {
                if (ui.text == "Press (R) to reset the level")
                {
                    ui.text = "Press (down arrow key) to tilt down";
                }
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                if (ui.text == "Press (down arrow key) to tilt down")
                {
                    ui.text = "Collect the coin to advance to Level 1!";
                    st = false;
                }
            }
        }


    }
}
