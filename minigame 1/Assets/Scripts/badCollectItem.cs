using UnityEngine;

public class badCollectItem : MonoBehaviour
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
        gameManager.calculateLives(-1);
        Destroy(gameObject);
    }
}
