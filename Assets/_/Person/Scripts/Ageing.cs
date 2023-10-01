using Events;
using UnityEngine;
using Variables;

[RequireComponent(typeof(Person))]
public class Ageing : MonoBehaviour {
  public FloatReference StudentAge;
  public FloatReference AdultAge;
  public FloatReference SeniorAge;
  public FloatReference DeadAge;

  public FloatVariable CurrentDay;

  public GameEvent OnDayStart;
  public float Birthday = 0; 

  private Person person;


  private void Start() {
    this.person = this.GetComponent<Person>();
    
    if (Birthday <= 0) {
      Birthday = 1;
    }
  }

  
  public void CheckAge() {
    if (Birthday == CurrentDay.Value) {
      person.Age++;

      CheckLifeStage();
    }
  }


  private void CheckLifeStage() {
    if (person.LifeStage == LifeStage.CHILD && person.Age >= StudentAge) {
      person.LifeStage = LifeStage.STUDENT;
    }

    if (person.LifeStage == LifeStage.STUDENT && person.Age >= AdultAge) {
      person.LifeStage = LifeStage.ADULT;
    }

    if (person.LifeStage == LifeStage.ADULT && person.Age >= SeniorAge) {
      person.LifeStage = LifeStage.SENIOR;
    }

    if (person.LifeStage == LifeStage.SENIOR && person.Age >= DeadAge) {
      Destroy(gameObject);
    }
  }
}