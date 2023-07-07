using UnityEngine;

public class minimap_cam_scr : MonoBehaviour
{

    public Transform ac;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(ac.position.x, ac.position.y + 100, ac.position.z);
        transform.forward = new Vector3(0, -1, 0);
        transform.up = new Vector3(0, 0, 1);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(ac.position.x, ac.position.y + 100, ac.position.z);
        transform.forward = new Vector3(0, -1, 0);
        transform.up = new Vector3(0, 0, 1);
    }
}
