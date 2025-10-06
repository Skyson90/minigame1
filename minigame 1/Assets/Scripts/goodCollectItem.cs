using UnityEngine;

public class goodCollectItem : MonoBehaviour
{
    //----Variable----
    private gameManager gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<gameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        gameManager.AddScore(100);
        Destroy(gameObject);
    }

}
