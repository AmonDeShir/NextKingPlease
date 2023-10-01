using UnityEngine;

public class Person : MonoBehaviour {
  public string Name;
  public int Age;
  public LifeStage LifeStage;

  public People people;

  public Construction inside;

  private void OnEnable() {
    people.Add(this);
  }

  private void OnDisable() {
    people.Remove(this);
  }

}

public enum LifeStage {
  CHILD,
  STUDENT,
  ADULT,
  SENIOR,
}