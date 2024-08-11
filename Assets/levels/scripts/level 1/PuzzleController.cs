using UnityEngine;
using UnityEngine.UI;

public class PuzzleController : MonoBehaviour
{
    public Button[] buttons; // قم بتعيين الأزرار في محرر Unity
    public GameObject door; // قم بتعيين الباب في محرر Unity
    public Sprite[] correctOrder; // تخزين الترتيب الصحيح للرموز

    private int currentButtonIndex = 0; // تتبع الترتيب الحالي للرموز

    void Start()
    {
        // تعيين دالة النقر على الأزرار
        for (int i = 0; i < buttons.Length; i++)
        {
            int buttonIndex = i; // تخزين الفهرس للأزرار
            buttons[i].onClick.AddListener(() => OnButtonClick(buttonIndex));
        }
    }

    void OnButtonClick(int buttonIndex)
    {
        // تحقق من أن الزر الذي تم النقر عليه يتوافق مع الترتيب الصحيح للرمز
        if (buttons[buttonIndex].image.sprite == correctOrder[currentButtonIndex])
        {
            currentButtonIndex++; // زيادة الفهرس للرموز بعد التطابق
            Debug.Log("Correct order!"); // اظهار رسالة توضيحية
        }
        else
        {
            // إعادة تعيين الفهرس للرموز في حالة عدم التطابق
            currentButtonIndex = 0;
            Debug.Log("Incorrect order!"); // اظهار رسالة توضيحية
        }

        // تحقق مما إذا تم تحقيق الترتيب الصحيح
        if (currentButtonIndex >= correctOrder.Length)
        {
            OpenDoor(); // فتح الباب إذا تم تحقيق الترتيب الصحيح
            Debug.Log("dooooooor!");
        }
    }

    void OpenDoor()
    {
        door.SetActive(false); // إخفاء الباب عند فتحه
        Debug.Log("Door opened!"); // اظهار رسالة توضيحية
    }
}
