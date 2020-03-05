using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeTracking : MonoBehaviour
{
    [Header("Time")]
    public float TimeTracker = 0f;
    public float Seconds;
    public float Minutes;
    public float Hours;

    [Header("Modifiers")]
    [SerializeField] private bool ConsistentMod = false;
    [SerializeField] private float Add;
    [SerializeField] private float Subtract;
    [SerializeField] private float Multiply;
    [SerializeField] private float Divide;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SecondsCounter());
        TimeTracker = Time.deltaTime;
        Multiply = 1f;
        Divide = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        TimeTracker += Time.deltaTime;
        SecondsToMinutesToHours();
        if (ConsistentMod == true)
        {
            ToggleTimeMod();
        }
        else
        {
            if (Input.GetKeyDown("space"))
            {
                ToggleTimeMod();
            }
        }
    }

    IEnumerator SecondsCounter()
    {
        yield return new WaitForSeconds(1);
        Seconds++;
        StartCoroutine(SecondsCounter());
    }

    private void SecondsToMinutesToHours()
    {
        if (Seconds == 60f)
        {
            Minutes += 1;
            Seconds = 0;
        }

        if (Minutes == 60f)
        {
            Hours += 1;
            Minutes = 0;
        }
    }

    private void ToggleTimeMod()
    {
        AddTime();
        SubtractTime();
        MultiplyTime();
        DivideTime();
    }

    private void AddTime()
    {
        TimeTracker += Add;
    }

    private void SubtractTime()
    {
        TimeTracker -= Subtract;
    }

    private void MultiplyTime()
    {
        TimeTracker *= Multiply;
    }

    private void DivideTime()
    {
        if (Divide != 0)
        {
            TimeTracker /= Divide;
        }
        else
        {
            Divide = 1f;
        }
    }
}
