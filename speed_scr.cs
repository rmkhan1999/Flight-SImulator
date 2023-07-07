using UnityEngine;
using UnityEngine.UI;

public class speed_scr : MonoBehaviour
{
    public Rigidbody ac;
    public Text speed;
    // Start is called before the first frame update
    void Start()
    {
        speed.text = ((int) (Vector3.Dot(ac.velocity, ac.transform.forward))).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        speed.text = ((int)(Vector3.Dot(ac.velocity, ac.transform.forward))).ToString();
    }
}
