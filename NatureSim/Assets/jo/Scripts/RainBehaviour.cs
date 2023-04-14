using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RainBehaviour : MonoBehaviour
{
    public ParticleSystem rain;
    public ParticleSystem raindrops;
    
    private ParticleSystem.ColorOverLifetimeModule rainColour;
    private ParticleSystem.ColorOverLifetimeModule raindropColour;
    private ParticleSystem.CollisionModule rainCollision;
    
    private Gradient rainGradient;
    
    private GradientColorKey[] graidentRainbow;
    private GradientColorKey[] graidentWhite;
    private GradientAlphaKey[] graidentAlpha;

    // public Slider rainbowToggle;
    public Slider speedToggle;
    // public Toggle gravityToggle;
    // public Toggle bouncyToggle;
    public Toggle rainToggle;

    private void Start()
    {
        rain = GameObject.FindWithTag("Rain").GetComponent<ParticleSystem>();
        raindrops = rain.transform.GetChild(0).GetComponent<ParticleSystem>();
        rain.Stop();
        rainToggle.isOn = false;
        rainColour = rain.colorOverLifetime;
        raindropColour = raindrops.colorOverLifetime;
        rainCollision = rain.collision;
        rainGradient = new Gradient();

        graidentRainbow = new GradientColorKey[7];
        graidentRainbow[0].color = new Color32(255, 0, 0, 255); //red
        graidentRainbow[0].time = 0.2f; //20% into the gradient
        graidentRainbow[1].color = new Color32(255, 165, 0, 255); //orange
        graidentRainbow[1].time = 0.3f; //30%
        graidentRainbow[2].color = new Color32(255, 255, 0, 255); //yellow
        graidentRainbow[2].time = 0.4f; //40%
        graidentRainbow[3].color = new Color32(0, 255, 0, 255); //green
        graidentRainbow[3].time = 0.5f; //50%
        graidentRainbow[4].color = new Color32(0, 0, 255, 255); //blue
        graidentRainbow[4].time = 0.6f; //60%
        graidentRainbow[5].color = new Color32(75, 0, 130, 255); //indigo
        graidentRainbow[5].time = 0.7f; //70%
        graidentRainbow[6].color = new Color32(143, 0, 255, 255); //violet
        graidentRainbow[6].time = 0.8f; //80%

        graidentWhite = new GradientColorKey[2];
        graidentWhite[0].color = Color.white;
        graidentWhite[0].time = 0.2f;
        graidentWhite[1].color = Color.white;
        graidentWhite[1].time = 0.8f;

        graidentAlpha = new GradientAlphaKey[4];
        graidentAlpha[0].alpha = 0f;
        graidentAlpha[0].time = 0f;
        graidentAlpha[1].alpha = 1f;
        graidentAlpha[1].time = 0.2f;
        graidentAlpha[2].alpha = 1f;
        graidentAlpha[2].time = 0.8f;
        graidentAlpha[3].alpha = 0f;
        graidentAlpha[3].time = 1f;
    }

    private void Update()
    {
        if (rainToggle.isOn)
        {
            if (!rain.isPlaying)
            {
                rain.Play();
            }
            
            var main = rain.main;
            main.simulationSpeed = speedToggle.value;
        
            // rainbowCheck();
            // GravityCheck();
            // BounceCheck();
        }

        else
        {
            rain.Stop();
        }

    }

    // private void rainbowCheck()
    // {
    //     if (rainbowToggle.value == 0)
    //     {
    //         RegularRain();
    //     }
    //
    //     else
    //     {
    //         RainbowRain();
    //     }
    // }

    private void RegularRain()
    {
        rainGradient.SetKeys(graidentWhite, graidentAlpha);
        rainColour.color = rainGradient;
        raindropColour.color = rainGradient;
    }

    private void RainbowRain()
    {
        rainGradient.SetKeys(graidentRainbow, graidentAlpha);
        rainColour.color = rainGradient;
        raindropColour.color = rainGradient;
    }

    // private void GravityCheck()
    // {
    //     if (bouncyToggle.isOn) return;
    //     
    //     if (gravityToggle.isOn)
    //     {
    //         AntiGravity();
    //     }
    //
    //     else
    //     {
    //         RegularGravity();
    //     }
    // }

    private void RegularGravity()
    {
        rain.gravityModifier = 0f;
    }

    private void AntiGravity()
    {
        rain.gravityModifier = -1f;
    }


    // private void BounceCheck()
    // {
    //     if (gravityToggle.isOn) return;
    //     
    //     if (bouncyToggle.isOn &&!gravityToggle.isOn)
    //     {
    //         BouncyRain();
    //     }
    //
    //     else
    //     {
    //         NonBouncyRain();
    //     }
    // }

    private void NonBouncyRain()
    {
        var main = rain.main;
        main.gravityModifier = 0;
        rainCollision.bounce = 0;
        rainCollision.dampen = 1;
    }

    private void BouncyRain()
    {
        var main = rain.main;
        main.gravityModifier = new ParticleSystem.MinMaxCurve(1, 10);
        rainCollision.bounce = 1;
        rainCollision.dampen = 0;
    }

}