

namespace GOAP {
  public abstract class Goal {
    /// <summary>
    /// This indicates if the goal should be considered or not.
    /// 
    /// Can be use to ignore Combat related goal when there are no enemy nearby.
    /// </summary>
    /// <returns></returns>
    public virtual bool IsValid();

    /// <summary>
    /// Returns goals priority.
    /// </summary>
    /// <returns></returns>
    public virtual int Priority();
    /// <summary>
    /// Plan's desired state. This is usually referred as desired world state, but it doesn't need to match the raw world state. 
    /// For example, in your world state you may store "hunger" as a number, but in goap you need to deal with it as "is_hungry".
    /// </summary>
    /// <returns></returns>
    public Dictionary GetDesiredState();
  }
}