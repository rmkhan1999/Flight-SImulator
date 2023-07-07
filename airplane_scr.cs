using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class airplane_scr : MonoBehaviour
{

    public Rigidbody rb;
    public Text lift_ui;
    
    public Transform ac;
    public bool freeze = false;
    public GameObject sp;

    public GameObject ResetPanel;

    public GameObject tp;

    public AudioSource audioSource;


    public int i = 0;

    public void hideTp()
    {
        tp.SetActive(false);
    }

    private void controls()
    {
        
        float forwardForce = 400;
        float breakForce = 100;
        float turnTorc = 75;
        float updownTorc = 50;
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(forwardForce * rb.transform.forward * Time.deltaTime);

        }

        if (Input.GetKeyDown(KeyCode.W))
        {

            audioSource.enabled = true;




        }

        if (Input.GetKeyUp(KeyCode.W))
        {

            audioSource.enabled = false;




        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-breakForce * rb.transform.forward * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(-turnTorc * rb.transform.up * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddTorque(turnTorc * rb.transform.up * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddTorque(-updownTorc * rb.transform.right * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddTorque(updownTorc * rb.transform.right * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddTorque(updownTorc * rb.transform.forward * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddTorque(-updownTorc * rb.transform.forward * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.R))
        {
            ResetPanel.SetActive(true) ;
        }
    }

    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void disableResetPanel()
    {
        ResetPanel.SetActive(false);

    }

    private void lift() 
    {
        const float k1 = 1.8F;
        const float k2 = 2.3F;
        const float max_alt = 5000;

        Vector3 v = rb.velocity;
        Vector3 u = transform.up;

        Vector3 lift = (k1 * ( Vector3.Dot(v,transform.forward) * Vector3.Dot(v, transform.forward)) * ((max_alt-transform.position.y)/max_alt) + k2) * u.normalized;
        if(lift.magnitude > 550)
        {
            lift = lift.normalized * 550;
        }
        rb.AddForce(lift * Time.deltaTime,ForceMode.Acceleration);

        lift_ui.text = ((int)(lift.magnitude)).ToString();
    }
    private void drag() 
    {
        const float k3 = 0.35F;
        const float k4 = 0.2F;
        const float k5 = 0.005F;
        const float k6 = 2;
        Vector3 v = rb.velocity;
        Vector3 w = -transform.forward;

        Vector3 drag = (k3 * (Vector3.Dot(v, transform.forward) * Vector3.Dot(v, transform.forward)) + k4) * w.normalized;
        rb.AddForce(drag * Time.deltaTime, ForceMode.Acceleration);
        Debug.Log(drag.magnitude.ToString());

        rb.angularDrag = (k5 * (Vector3.Dot(v, transform.forward) * Vector3.Dot(v, transform.forward)) + k6);
    }

    

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {

            audioSource.enabled = true;




        }

        if (Input.GetKeyUp(KeyCode.W))
        {

            audioSource.enabled = false;




        }
    }







    // Update is called once per frame
    void FixedUpdate()
    {
        
       
        controls();
       
        lift();
        drag();
    }


   
}
