using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveWandMinigameStep : MinigameStep
{
    public override event EventHandler<MedalType> OnMinigameStepOver;
    [SerializeField] Timer timer;
    float timerDuration = 10f;

    public override bool StartMinigameStep()
    {
        Debug.Log("Wave wand minigame started");
        timer.StartTimer(timerDuration, OnTimerFinished);
        return true;
    }

    void OnTimerFinished()
    {
        OnMinigameStepOver.Invoke(this, MedalType.None);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Wave wand Minigame step complete");
            OnMinigameStepOver.Invoke(this, MedalType.Bronze);
        }
    }
}