using System.Collections.Generic;
using UnityEngine;

public class MissionManager : MonoBehaviour
{
    [SerializeField] private MissionGroupConfig _missionGroupConfig;

    private readonly List<MissionSequenceRunner> _missionSequenceRunners = new();

    private void Start()
    {
        if (_missionGroupConfig == null)
        {
            Debug.LogError("MissionGroupConfig не назначен в инспекторе в MissionManager.");
            return;
        }

        foreach (MissionSequenceConfig missionSequenceConfig in _missionGroupConfig.MissionSequences)
        {
            MissionSequenceRunner missionSequenceRunner = new MissionSequenceRunner(missionSequenceConfig);
            _missionSequenceRunners.Add(missionSequenceRunner);
            missionSequenceRunner.Start();
        }
    }
}
