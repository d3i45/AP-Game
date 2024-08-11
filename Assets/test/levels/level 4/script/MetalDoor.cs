using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalDoor : MonoBehaviour
{
    public GameObject door; // The door object that will be opened
    private bool isOpened = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isOpened)
        {
            PlayerInventory inventory = other.GetComponent<PlayerInventory>();
            if (inventory != null && inventory.HasAllKeyPieces())
            {
                OpenDoor();
            }
            else
            {
                Debug.Log("You need more key pieces to open this door.");
            }
        }
    }

    private void OpenDoor()
    {
        isOpened = true;
        // Logic to open the door, e.g., play an animation or set the door to inactive
        door.SetActive(false);
        Debug.Log("Door opened!");
    }
}
