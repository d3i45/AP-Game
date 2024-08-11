using UnityEngine;
using UnityEngine.UI;

public class WoodenKeyPuzzle : MonoBehaviour
{
    public string correctCode = "1234"; // Example code
    public InputField codeInputField;
    public GameObject key;

    public door door;
    public GameObject box;

    void Start()
    {
        key.SetActive(false);
    }

    public void CheckCode()
    {
        if (codeInputField.text == correctCode)
        {
            Debug.Log("Correct Code!");
            key.SetActive(true);
            door.collectedGems++;
            box.SetActive(false);
            // Additional logic to open the box
        }
        else
        {
            Debug.Log("Incorrect Code!");
        }
    }
}
