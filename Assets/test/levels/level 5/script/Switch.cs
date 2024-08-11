using UnityEngine;

public class Switch : MonoBehaviour
{
    public bool isActivated = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isActivated)
        {
            ActivateSwitch();
        }
    }

    private void ActivateSwitch()
    {
        isActivated = true;
        // Logic to change the appearance of the switch
        GetComponent<SpriteRenderer>().color = Color.green; // Example: change color to green
        Debug.Log("Switch activated!");
        // Notify the central controller about this activation
        SwitchController.Instance.SwitchActivated(this);
    }
}
