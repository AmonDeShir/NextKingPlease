using Events;
using Unity.VisualScripting;
using UnityEngine;
using Variables;

public class PassingTime : MonoBehaviour {
  public FloatVariable Minute;
  public FloatVariable Hour;
  public FloatVariable Day;
  public FloatVariable Year;
  public BoolVariable IsDay;

  [Header("Passing time settings")]
  public FloatReference GameSpeed;
  public FloatReference MinutesInHour;
  public FloatReference HoursInDay;
  public FloatReference HoursInNight;
  public FloatReference DaysInYear;

  [Header("Events")]
  public GameEvent OnHourStart;
  public GameEvent OnDayStart;
  public GameEvent OnYearStart;
  public GameEvent OnNightStart;

  private void Update() {
    Minute.ApplyChange(Time.deltaTime * GameSpeed);
    bool hourChange = false;
    bool dayChange = false;

    if (Minute.Value > MinutesInHour) {
      Hour.Value += Mathf.Floor(Minute.Value / MinutesInHour);
      Minute.Value %= MinutesInHour;
      
      hourChange = true;
    }

    if (Hour.Value > HoursInDay + HoursInNight) {
      Day.Value += Mathf.Floor(Hour.Value / (HoursInDay + HoursInNight));
      Hour.Value %= HoursInDay + HoursInNight;

      dayChange = true;
    }

    if (Day.Value > DaysInYear) {
      Year.Value += Mathf.Floor(Day.Value / DaysInYear);
      Day.Value %= DaysInYear;

      OnYearStart.Raise();
    }

    if (Hour.Value > HoursInDay && IsDay) {
      OnNightStart.Raise();
    }

    IsDay.Value = Hour.Value < HoursInDay;

    if (hourChange) {
      OnHourStart.Raise();
    }

    if (dayChange) {
      OnDayStart.Raise();
    }
  }
}