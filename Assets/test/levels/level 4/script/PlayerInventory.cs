using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventory : MonoBehaviour
{
  public int totalKeyPieces = 3; // Total number of key pieces needed
    private int collectedKeyPieces = 0;
    public Text keyPiecesText; // Reference to the Text UI element

    void Start()
    {
        keyPiecesText.text = "Key Pieces: 0/" + totalKeyPieces;
    }

    public void AddKeyPiece()
    {
        collectedKeyPieces++;
        keyPiecesText.text = "Key Pieces: " + collectedKeyPieces + "/" + totalKeyPieces;
        Debug.Log("Collected Key Pieces: " + collectedKeyPieces);
        
        if (collectedKeyPieces >= totalKeyPieces)
        {
            Debug.Log("All key pieces collected!");
            // Additional logic for when all key pieces are collected
        }
    }

    public bool HasAllKeyPieces()
    {
        return collectedKeyPieces >= totalKeyPieces;
    }
}
