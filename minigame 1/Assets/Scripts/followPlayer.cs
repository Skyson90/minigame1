using UnityEngine;

/*-------------------------------------------------
#   File Name: followPlayer.cs
#   Date: 10/5/2025
#   Author: Guilherme Oliveira
#
#   Desc: Allows the camera to follow thge player 
#   as they play
-------------------------------------------------*/
public class followPlayer : MonoBehaviour
{
    //----Variables----
    public GameObject player;

    private Vector3 offsetPos = new Vector3(0, 4, -8);


    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offsetPos;

    }
}
