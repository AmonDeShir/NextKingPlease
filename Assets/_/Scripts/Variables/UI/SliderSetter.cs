using UnityEngine;
using UnityEngine.UI;

namespace Variables.UI {
  [ExecuteInEditMode]
  public class SliderSetter : MonoBehaviour {
    public Slider Slider;
    public FloatVariable Variable;
    
    private void Update() {
      if (Slider != null && Variable != null) {
        Slider.value = Variable.Value;
      }
    }
  }
}