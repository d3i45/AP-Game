using UnityEngine;

public class SwitchController : MonoBehaviour
{
    public static SwitchController Instance;
    public Switch[] switches; // Array to hold references to all switches
    public Machine[] machines; // Array to hold references to all machines
    public GameObject hiddenDoor; // مرجع للباب المخفي

    private int activatedSwitchCount = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SwitchActivated(Switch switchActivated)
    {
        activatedSwitchCount++;
        Debug.Log("Switch activated count: " + activatedSwitchCount); // رسالة تأكيد

        if (activatedSwitchCount == switches.Length)
        {
            Debug.Log("All switches activated!"); // رسالة تأكيد
            ActivateMachines();
            ShowHiddenDoor(); // إظهار الباب المخفي
        }
    }

    private void ActivateMachines()
    {
        foreach (Machine machine in machines)
        {
            machine.ActivateMachine();
        }
    }

    private void ShowHiddenDoor()
    {
        if (hiddenDoor != null)
        {
            hiddenDoor.SetActive(true); // تفعيل الباب المخفي ليصبح مرئيًا
            Debug.Log("Hidden door revealed!");
        }
    }
}
