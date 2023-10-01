using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Variables {
  [CreateAssetMenu]
  public class BoolVariable : ScriptableObject {
    public bool DefaultValue;

    [SerializeField]
    private bool value;

    #if UNITY_EDITOR
    [Multiline]
    public string DeveloperDescription = "";
    #endif

    private void OnEnable() {
      value = DefaultValue;
    }   

    public bool Value {
      get { return value; }
      set { this.value = value; }
    }

    public void Toggle() { 
      this.value = !value;
    }
  }
}