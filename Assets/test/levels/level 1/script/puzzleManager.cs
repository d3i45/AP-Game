using UnityEngine;
using UnityEngine.UI;

public class puzzleManager : MonoBehaviour
{
    public Button[] buttons; // Array of buttons
    private int emptyIndex;  // Index of the empty space

    public GameObject GameObjectE;
    public GameObject GameObjectEE;
    public GameObject GameObjectD;
    public GameObject GameObjectEEE;
    public GameObject GameObjectToDestroy;
    void Start()
    {
         // Initialize buttons and find the empty space index
    for (int i = 0; i < buttons.Length; i++)
    {
        if (buttons[i].GetComponentInChildren<Text>().text == "")
        {
            emptyIndex = i;
            break;
        }
    }

    // Add listeners to buttons
    for (int i = 0; i < buttons.Length; i++)
    {
        int index = i;
        buttons[i].onClick.AddListener(() => OnButtonClick(index));
    }
    }

    public void OnButtonClick(int index)
    {
        Debug.Log($"Button {index} clicked.");
        
        // Check if the clicked button is adjacent to the empty space
        if (IsAdjacent(index, emptyIndex))
        {
            SwapButtons(index, emptyIndex);
            emptyIndex = index; // Update the empty space index
            CheckForWin();
        }
    }

    bool IsAdjacent(int index1, int index2)
    {
        // Check if two indices are adjacent on a 3x3 grid
        int row1 = index1 / 3;
        int col1 = index1 % 3;
        int row2 = index2 / 3;
        int col2 = index2 % 3;

        return (Mathf.Abs(row1 - row2) + Mathf.Abs(col1 - col2)) == 1;
    }

    void SwapButtons(int index1, int index2)
    {
        // Swap the text values of two buttons
        Text text1 = buttons[index1].GetComponentInChildren<Text>();
        Text text2 = buttons[index2].GetComponentInChildren<Text>();

        string temp = text1.text;
        text1.text = text2.text;
        text2.text = temp;
    }

    void CheckForWin()
    {
        for (int i = 0; i < buttons.Length - 1; i++)
        {
            if (buttons[i].GetComponentInChildren<Text>().text != (i + 1).ToString())
            {
                return;
            }
        }

        Debug.Log("You Win!");
        GameObjectD.SetActive(false);
        GameObjectE.SetActive(true);
        GameObjectEE.SetActive(true);
        GameObjectEEE.SetActive(true);
        GameObjectToDestroy.SetActive(false);
        // Add more logic for when the player wins
    }
}
