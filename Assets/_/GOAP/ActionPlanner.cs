using System.Collections.Generic;
using NUnit.Framework.Internal;

namespace GOAP {
  public class ActionPlayer {
    private List<Action> actions;

    public ActionPlayer() {
      actions = new List<Action>();
    }

    public void SetActions(List<Action> actions) {
      this.actions = actions;
    }

    public void AddAction(Action action) {
      if(!actions.Contains(action)) {
        actions.Add(action);
      }
    }

    public void RemoveAction(Action action) {
      if(actions.Contains(action)) {
        actions.Remove(action);
      }
    }

    public List<Action> GetPlan(Goal goal) {
      return null;
    }
    
  }
}