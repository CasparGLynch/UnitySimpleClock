using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField]
    Transform hoursPivot;
    
    [SerializeField]
    Transform minutesPivot;
    
    [SerializeField]
    Transform secondsPivot;

    const float hourstoDegrees = -30f;
    const float minutesToDegrees = -6f;
    const float secondsToDegrees = -6f;
    // Start is called before the first frame update
    void Awake()
    {
        var time = DateTime.Now;
        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hourstoDegrees * time.Hour);
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * time.Minute);
        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * time.Second);
    }

    void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hourstoDegrees * (float) time.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * (float) time.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * (float) time.TotalSeconds);
    }
}
