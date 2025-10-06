using UnityEngine;

public class moveTowardsPlayer : MonoBehaviour
{
    //----Variables----
    public float speed = 7.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }
}
