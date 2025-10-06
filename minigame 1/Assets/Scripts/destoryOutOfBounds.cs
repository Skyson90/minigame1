using UnityEngine;

public class destoryOutOfBounds : MonoBehaviour
{
    //----Variables---
    private float outOfBounds = -25;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < outOfBounds)
        {
            Destroy(gameObject);
        }
    }
}
