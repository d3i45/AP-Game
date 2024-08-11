using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextTransparencyController : MonoBehaviour
{
    public Text[] targetTexts; // مصفوفة تحتوي على مراجع إلى كائنات النص
    public float fadeInDuration = 5f; // مدة التلاشي بالثواني
    public float fadeOutDuration = 2.5f; // مدة الإخفاء بالثواني (نصف مدة التلاشي)

    void Start()
    {
        // التحقق من أن هناك على الأقل عنصر واحد في المصفوفة
        if (targetTexts.Length > 0)
        {
            // تعيين الشفافية الأولية لكل كائن نص في المصفوفة إلى صفر
            foreach (Text text in targetTexts)
            {
                if (text != null)
                {
                    Color color = text.color;
                    color.a = 0f;
                    text.color = color;
                }
            }

            // بدء عملية التلاشي بالتسلسل
            StartCoroutine(FadeInTextsSequentially());
        }
    }

    IEnumerator FadeInTextsSequentially()
    {
        foreach (Text text in targetTexts)
        {
            if (text != null)
            {
                yield return StartCoroutine(FadeInText(text));
                yield return StartCoroutine(FadeOutText(text));
            }
        }
    }

    IEnumerator FadeInText(Text text)
    {
        float elapsedTime = 0f;
        Color color = text.color;

        while (elapsedTime < fadeInDuration)
        {
            elapsedTime += Time.deltaTime;
            color.a = Mathf.Clamp01(elapsedTime / fadeInDuration);
            text.color = color;
            yield return null;
        }

        // التأكد من أن الشفافية هي 1 (255)
        color.a = 1f;
        text.color = color;
    }

    IEnumerator FadeOutText(Text text)
    {
        float elapsedTime = 0f;
        Color color = text.color;

        while (elapsedTime < fadeOutDuration)
        {
            elapsedTime += Time.deltaTime;
            color.a = Mathf.Clamp01(1f - (elapsedTime / fadeOutDuration));
            text.color = color;
            yield return null;
        }

        // التأكد من أن الشفافية هي 0 (0)
        color.a = 0f;
        text.color = color;
    }
}
