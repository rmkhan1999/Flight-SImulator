using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class coin_ui_scr : MonoBehaviour
{

    private int CoinsCollected = 0;
    public Text ui;
    public GameObject panel;
    public int i = 0;
    public int j = 0;
    public int end;
    public bool nextScene;
    public bool trigger = false;
    public Text c;
    public Text x;
    // Start is called before the first frame update
    void Start()
    {
        ui.text = CoinsCollected.ToString();
        c.enabled = false;
    }

    // Update is called once per frame
    void Update()


    {
        if (trigger)
        {

            c.enabled = true;
            j++;

            if (j > 1600)
            {
                c.enabled = false;

                j = 0;
                trigger = false;

            }

        }


        if (CoinsCollected == end)
        {
            panel.SetActive(true);
            x.text = "";

            i++;
            if (nextScene)
            {


                if (i > 1500)
                {

                    UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                    i = 0;
                }
            }
        }


        ui.text = CoinsCollected.ToString();
    }

    public void AddCoin()
    {
        CoinsCollected++;
        trigger = true;
    }

}
