using UnityEngine;
using UnityEngine.UI;

namespace Variables.UI {
  public class TextReplacer : MonoBehaviour {
    public Text Text;
    public StringVariable Variable;
    public bool AlwaysUpdate;

    private void OnEnable() {
      Text.text = Variable.Value;      
    }

    void Update() {
      if (AlwaysUpdate) {
        Text.text = Variable.Value;
      }
    }
  }
}