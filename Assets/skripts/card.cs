using System;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;
public class card : MonoBehaviour
{
    private Timer timer;
    [SerializeField] private Slider slider;
    [SerializeField] private float interval = 1;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        timer = new Timer(interval);
        timer.Start();
        timer.Elapsed += OnTimedEvent;
    }


    // Update is called once per frame
    void Update()
    {
        






    }
    private void OnTimedEvent(System.Object source, ElapsedEventArgs e)
    {
        slider.value = 0;
    }
}
