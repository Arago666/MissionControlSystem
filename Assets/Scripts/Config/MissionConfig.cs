using UnityEngine;

[CreateAssetMenu(menuName = "Missions/MissionConfig", fileName = "MissionConfig")]
public class MissionConfig : ScriptableObject
{
    public string MissionName;
    public float Delay;
    public GameObject  MissionPrefab;
}
