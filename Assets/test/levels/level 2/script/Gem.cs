using UnityEngine;

public class Gem : MonoBehaviour
{
    public door door;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Logic for collecting the gem
            Debug.Log("Gem collected!");
            door.CollectGem();
            Destroy(gameObject);
        }
    }
}

