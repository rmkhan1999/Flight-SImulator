using UnityEngine.UI;
using UnityEngine;

public class coin_scr : MonoBehaviour
{

    public MeshRenderer mr;
    public CapsuleCollider cc;
    public Text ui;
 
    public int i = 0;
    public bool trigger = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        mr.enabled = false;
        cc.enabled = false;
        ui.SendMessage("AddCoin");
        trigger = true;
    }
}
