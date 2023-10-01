using System;
using Events;
using UnityEngine;
using Variables;

public class Needs : MonoBehaviour {
  public float Hunger = 100f;
  public float Hydration = 100f;
  public float Social = 100f;
  public bool hasHouse = false;
  
  public float HungerModifier = -0.1f;
  public float HydrationModifier = -0.2f;
  public float SocialModifier = -0.01f;

  public FloatReference GameSpeed;


  private void Update() {
    float time = Time.deltaTime * GameSpeed;

    Hunger = Math.Clamp(Hunger + HungerModifier * time, 0, 100);
    Hydration = Math.Clamp(Hydration + HydrationModifier * time, 0, 100);
    Social = Math.Clamp(Social + SocialModifier * time, 0, 100);
  }
}
