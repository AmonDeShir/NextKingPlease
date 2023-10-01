
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Asset/ConstructionType")]
public class ConstructionType : ScriptableObject {
  public string Name;
  public int Size;
  public float ConstructionTime;
}