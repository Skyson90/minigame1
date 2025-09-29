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

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        /*--------------------------------
        # Author: Guilherme Oliveira
        # Date: 9/29/25
        # Desc: Moves the game object 
        # based on the player's input
        --------------------------------*/
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
    }
}
