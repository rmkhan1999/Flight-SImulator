using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour

{
    public airplane_scr ap;
    public int i = 0;
    public int j = 0;
    public bool collided = false;
    
    public Rigidbody rb;
    public Transform ac;

    public GameObject panel;
    public GameObject DPanel;

    public void ShowPanel()
    {
        panel.SetActive(true);
    }

    public void ShowDPanel()
    {
        DPanel.SetActive(true);
    }


    private void Update()
    {
        if (collided)
        {
            if (j < 200)
            {
                j++;
            }

            else
            {
                ShowPanel();
                j = 0;
            }
            
            ShowDPanel();

            if (i < 1200)
            {
                i++;
            }

            else
            {
                reset();
                
                collided = false;
                ap.enabled = true;
                i = 0;
            }

            
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Sphere")
        {

            ap.enabled = false;
            
            collided = true;
            
            

        }
    }

    private void reset()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }

}
