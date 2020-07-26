using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody Player;

    public float ForcaFrente = 1000f;
    public float ForcaLados = 500f;
    public float ForcaPulo = 100f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Player.AddForce(0, 0, ForcaFrente * Time.deltaTime);

        if (Input.GetKey("a"))
        {
            Player.AddForce(-ForcaLados * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            Player.AddForce(ForcaLados * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("space"))
        {
            Player.AddForce(0, ForcaLados * Time.deltaTime, 0);
        }
    }
}
