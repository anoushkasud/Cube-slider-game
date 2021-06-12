using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public float fwdForce = 1000f;
    public float sideForce = 1000f;
    // Start is called before the first frame update
    public Rigidbody x;
    void Start()
    {
        x = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    private void FixedUpdate()
    {
        
        x.AddForce(0, 0, fwdForce * Time.deltaTime);
        if (Input.GetKey("d")||Input.GetKey(KeyCode.RightArrow))
        {
            x.AddForce(sideForce * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey("a")||Input.GetKey(KeyCode.LeftArrow))
        {
            x.AddForce(-sideForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("j"))
        {
            x.AddForce(0,1000*Time.deltaTime,0 );
        }
    }
}
