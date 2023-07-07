using UnityEngine;
using UnityEngine.UI;

public class stabilizer_scr : MonoBehaviour
{
    public Rigidbody rb;
    public Transform stabilizer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            stabilizer.forward = (rb.transform.forward - (rb.transform.right * 0.1F)).normalized;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            stabilizer.forward = (rb.transform.forward + (rb.transform.right * 0.1F)).normalized;
        }
        
    }
}
