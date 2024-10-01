using System;
using System.Collections;
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

    private void Awake () {
  
      hoursPivot.localRotation = Quaternion.Euler(0,0,-30);
      minutesPivot.localRotation = Quaternion.Euler(0,0,0);
      secondsPivot.localRotation = Quaternion.Euler(0,0,0);
    } 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(DateTime.Now);
        hoursPivot.localRotation = Quaternion.Euler(0,0,-30 * DateTime.Now.Hour);
        minutesPivot.localRotation = Quaternion.Euler(0,0,-6 * DateTime.Now.Minute);
        secondsPivot.localRotation = Quaternion.Euler(0,0,-6 * DateTime.Now.Second);  
    }
}
