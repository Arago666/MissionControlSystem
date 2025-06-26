using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Missions/MissionChainConfig", fileName = "MissionChainConfig")]
public class MissionSequenceConfig : ScriptableObject
{
    public List<MissionConfig> Missions = new List<MissionConfig>();
}
