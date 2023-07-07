
using UnityEngine;

public class cam_scr_airplane : MonoBehaviour
{
    public Transform ac;
    private char view = 'o';// overhead view

    // Start is called before the first frame update
    void Start()
    {
        transform.position = ac.position + new Vector3(0, 2, -7);
        transform.forward = (ac.position - transform.position);
    }

    private void setView()
    {
        if(view == 'o')
        {
            transform.position = ac.position - ac.forward.normalized * 7 + new Vector3(0,2,0);
            transform.forward = (ac.position - transform.position);
            transform.up.Set(0, 1, 0);
        }

        if(view == 'f') // first person
        {
            transform.position = ac.position;
            if (Input.GetKey(KeyCode.R))
            {
                transform.forward = ac.right;
                transform.up = ac.up;
            }
            else if (Input.GetKey(KeyCode.L))
            {
                transform.forward = -ac.right;
                transform.up = ac.up;
            }
            else if (Input.GetKey(KeyCode.U))
            {
                transform.forward = ac.up;
                transform.up = -ac.forward;
            }
            else
            {
                transform.forward = ac.forward;
                transform.up = ac.up;
            }
        }
    }

    private void changeView()
    {
        if(view == 'o')
        {
            view = 'f';
        }
        else if(view == 'f')
        {
            view = 'o';
        }
    } 
    // Update is called once per frame
    void FixedUpdate()
    {
       
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            changeView();
        }
        setView();
        
    }
}
