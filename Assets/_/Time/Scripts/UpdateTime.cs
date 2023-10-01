using TMPro;
using UnityEngine;
using Variables;

public class UpdateTime : MonoBehaviour {
  public TMP_Text Text;
  public FloatVariable Year;
  public FloatVariable Day;
  public FloatVariable Hour;
  public FloatVariable Minute;

  private void Update() {
    Text.text = "Year: " + Year.Value + " Day: " + Day.Value + " Hour: " + Hour.Value + " Minute: " + Mathf.Floor(Minute.Value);
  }
}
