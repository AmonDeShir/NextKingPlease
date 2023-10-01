using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Variables {
  [CreateAssetMenu]
  public class StringVariable : ScriptableObject {
    public string DefaultValue;

    #if UNITY_EDITOR
    [Multiline]
    public string DeveloperDescription = "";
    #endif

    [SerializeField]
    private string value;

    public string Value {
      get { return value; }
      set { this.value = value; }
    }

    private void OnEnable() {
      value = DefaultValue;
    }    
  }
}