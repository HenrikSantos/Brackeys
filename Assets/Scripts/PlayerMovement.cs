using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody Player;

    public float ForcaFrente = 1000f;
    public float ForcaLados = 500f;

    

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
            Player.AddForce(-ForcaLados * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            Player.AddForce(ForcaLados * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Player.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }
}
