using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public Text textField; // تعيين الحقل النصي في محرر Unity
    [TextArea]
    public string[] displayTexts; // النصوص التي سيتم عرضها
    private int currentIndex = 0; // الفهرس الحالي للنصوص

    void Start()
    {
        // عرض النص الأول عند بدء التشغيل
        if (displayTexts.Length > 0)
        {
            textField.text = displayTexts[currentIndex];
        }
    }

    public void SwitchText()
    {
        if (displayTexts.Length > 0)
        {
            // زيادة الفهرس والتأكد من عدم تجاوز الحد الأقصى
            currentIndex = (currentIndex + 1) % displayTexts.Length;
            // عرض النص التالي
            textField.text = displayTexts[currentIndex];
        }
    }
}
