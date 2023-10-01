using System.Collection;

namespace GOAP {
  public abstract class Action {
    /// <summary>
    /// This indicates if the action should be considered or not.
    /// </summary>
    /// <returns></returns>
    public virtual bool IsValid();
    /// <summary>
    /// Action Cost. This is a function so it handles situational costs, when the world state is considered when calculating the cost.
    /// </summary>
    /// <param name="word"></param>
    /// <returns></returns>
    public virtual int GetCost(WordState word);
    /// <summary>
    /// Action requirements.
    /// </summary>
    /// <returns></returns>
    public virtual Dictionary<string, bool> GetPreconditions();
    /// <summary>
    /// What conditions this action satisfies
    /// </summary>
    /// <returns></returns>
    public virtual Dictionary<string, bool> GetEffects();
    /// <summary>
    /// Action implementation called on every loop.
    /// </summary>
    /// <param name="actor">the NPC using the AI</param>
    /// <param name="needs">the NPC's needs</param>
    /// <param name="wordState">Current word state</param>
    /// <param name="time">Time since last frame</param>
    /// <returns>Returns true when the task is complete.</returns>
    public virtual bool Perform(Person actor, Needs needs, WordState wordState, float time);
  }
}
