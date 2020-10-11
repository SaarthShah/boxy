using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody Rb;
    // Start is called before the first frame update
    public float fforce = 1000f;
    public float sideforce = 1000f;
    public float upforce = 100f;
    void Start()
    {
        Debug.Log("Thank you for starting the Game");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rb.AddForce(0,0,fforce*Time.deltaTime);
        if(Input.GetKey("d"))
        {
            Rb.AddForce(sideforce * Time.deltaTime, 0, 0);
                }
        if(Input.GetKey("a"))
        {
            Rb.AddForce(-sideforce * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey("w"))
        {
            Rb.AddForce(0, upforce * Time.deltaTime, 0,ForceMode.Force);
        }
        if(Rb.position.y < -1.09)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
