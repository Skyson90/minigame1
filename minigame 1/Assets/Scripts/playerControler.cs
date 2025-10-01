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
    public float horizontalInput;
    public float verticalInput;
    public float speed = 20.0f;
    public float jumpForce = 10.0f;
    public float gravityModifier;
    public bool isOnGround = true;

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
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround) 
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    // Is called once the player colides with the ground
    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}
