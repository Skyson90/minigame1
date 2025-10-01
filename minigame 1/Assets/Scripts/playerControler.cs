using UnityEngine;


/*-------------------------------------------------
#   File Name: playerContoller.cs
#   Date: 9/29/2025
#   Author: Guilherme Oliveira
#
#   Desc: Will allow the current PLayer to move 
#   around in the world/enviorment using either 
#   the arrow keys or WASD and Jump
-------------------------------------------------*/
public class playerControler : MonoBehaviour
{

    //---- Variables ----
    private float horizontalInput;
    private float verticalInput;
    public float speed = 20.0f;
    public float jumpForce = 10.0f;
    public float gravityModifier;
    private int jumps = 0;
    public int maxJumps = 2;

    private Rigidbody playerRb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {

        /*-----------------------------------------
        # Author: Guilherme Oliveira
        # Date: 9/29/25
        # Desc: Moves the game object based on the 
        # player's input
        -----------------------------------------*/
        // Movement across the X and Z axis
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        //Movement across the Y axis
        if (Input.GetKeyDown(KeyCode.Space) && jumps < maxJumps) 
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumps += 1;
        }
    }

    // Is called once the player colides with the ground
    private void OnCollisionEnter(Collision collision)
    {
        jumps = 0;
    }
}
