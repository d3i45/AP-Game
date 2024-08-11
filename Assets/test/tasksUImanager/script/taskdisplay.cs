using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class taskdisplay : MonoBehaviour
{
  [System.Serializable]
    public class Task
    {
        public string description;
        public bool isCompleted;
    }

    public List<Task> tasks = new List<Task>(); // قائمة المهام
    public Text currentTaskText; // نص عرض المهمة الحالية
    public Button completeTaskButton; // زر إكمال المهمة
    public Text scoreText; // نص عرض النقاط

    private int currentTaskIndex = 0; // مؤشر المهمة الحالية
    private int score = 0; // النقاط

    void Start()
    {
        completeTaskButton.onClick.AddListener(CompleteTask);
        UpdateTaskDisplay();
        UpdateScoreText();
    }

    // وظيفة لتحديث عرض المهمة الحالية
    void UpdateTaskDisplay()
    {
        if (currentTaskIndex < tasks.Count)
        {
            currentTaskText.text = tasks[currentTaskIndex].description;
        }
        else
        {
            currentTaskText.text = "All tasks completed!";
            completeTaskButton.interactable = false; // تعطيل زر إكمال المهمة عند إكمال جميع المهام
        }
    }

    // وظيفة لإكمال المهمة الحالية
    void CompleteTask()
    {
        if (currentTaskIndex < tasks.Count && !tasks[currentTaskIndex].isCompleted)
        {
            tasks[currentTaskIndex].isCompleted = true;
            score += 10; // إضافة نقاط عند إكمال المهمة
            currentTaskIndex++;
            UpdateTaskDisplay();
            UpdateScoreText();
        }
    }

    // وظيفة لتحديث نص النقاط
    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
