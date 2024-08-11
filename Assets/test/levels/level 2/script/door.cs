using UnityEngine;

public class door : MonoBehaviour
{
    public int requiredGems = 3; // Number of gems needed to open the door
    public int collectedGems = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (collectedGems >= requiredGems)
            {
                // Logic for opening the door
                Debug.Log("Door opened!");
                Destroy(gameObject); // Or implement door opening animation
            }
            else
            {
                Debug.Log("Collect more gems to open the door!");
            }
        }
    }

    public void CollectGem()
    {
        collectedGems++;
    }
}
