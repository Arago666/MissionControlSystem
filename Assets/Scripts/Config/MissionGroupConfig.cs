using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Missions/MissionGroupConfig", fileName = "MissionGroupConfig")]
public class MissionGroupConfig : ScriptableObject
{
    public List<MissionSequenceConfig> MissionSequences = new List<MissionSequenceConfig>();
}
