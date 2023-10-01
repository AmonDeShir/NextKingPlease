using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Variables {
  [CreateAssetMenu]
  public class FloatVariable : ScriptableObject {
    public float DefaultValue;

    #if UNITY_EDITOR
    [Multiline]
    public string DeveloperDescription = "";
    #endif

    [SerializeField]
    private float value;

    public float Value {
      get { return value; }
      set { this.value = value; }
    }

    private void OnEnable() {
      value = DefaultValue;
    }    

    public void ApplyChange(float value) {
      Value += value;
    }

    public void ApplyChange(FloatVariable value) {
      Value += value.Value;
    }

    public void Increment() {
      value++;
    }

    public void Decrement() {
      value--;
    }
  }
}