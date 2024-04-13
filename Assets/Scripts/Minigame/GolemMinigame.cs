using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolemMinigame : Minigame
{
    public override event EventHandler<MinigameScore> OnMinigameOver;

    public override bool StartMinigame()
    {
        throw new System.NotImplementedException();
        //Get each minigame from the list of steps

        //Start each minigame step

        //Wait for score from minigame step

        //Start next minigame step 

        //After all steps, calculate final score

        //Invoke OnMinigameOver and pass this final score back
    }

    // Start is called before the first frame update
    void Start()
    {
        timer.SetTime(5);
        timer.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer.GetTime() < 0) 
        {
            //End minigame
            OnMinigameOver.Invoke(this, MinigameScore.None);
            
        }
    }
}