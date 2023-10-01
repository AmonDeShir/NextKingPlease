using System;
using UnityEngine;

public class Construction : MonoBehaviour {
  public string Name;
  public BuiltConstructionSet Set;
  public ConstructionType Type;
  public GameObject Place;

  public int FreePlaces {
    get { return Math.Max(Type.Size - Place.transform.childCount, 0); }
  }

  private void OnEnable() {
    Set.Add(this);
  }

  private void OnDisable() {
    Set.Remove(this);
  }

  public void Enter(Person person) {
    if(FreePlaces > 0) {
      person.transform.SetParent(Place.transform);
    }
  }
}
