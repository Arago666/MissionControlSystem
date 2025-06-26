using Cysharp.Threading.Tasks;
using UnityEngine;

public sealed class MissionSequenceRunner
{
    private readonly MissionSequenceConfig _missionSequenceConfig;
    private int _index = -1;

    public MissionSequenceRunner(MissionSequenceConfig missionSequenceConfig) =>
        _missionSequenceConfig = missionSequenceConfig;

    public void Start() => StartNextMission();

    private void StartNextMission()
    {
        _index++;
        if (_index >= _missionSequenceConfig.Missions.Count) return;

        MissionConfig missionConfig = _missionSequenceConfig.Missions[_index];
        
        if (missionConfig == null)
        {
            Debug.LogError($"В ScriptableObject {_missionSequenceConfig.name} не заполнена {_index + 1} миссия!");
            return;
        }

        if (missionConfig.Delay > 0f)
            new Timer().StartAsync(Mathf.RoundToInt(missionConfig.Delay * 1000), 
                () => RunMission(missionConfig)).Forget();
        else
            RunMission(missionConfig);
    }

    private void RunMission(MissionConfig missionConfig)
    {
        GameObject missionPrefab = Object.Instantiate(missionConfig.MissionPrefab);

        if (!missionPrefab.TryGetComponent(out IMission mission))
        {
            Debug.LogError($"MissionPrefab {missionPrefab.name} не содержит скрипта миссии IMission.");
            return;
        }

        mission.OnStarted += () => Debug.Log($"{missionConfig.MissionName} - миссия началась.");
        mission.OnMissionPointReached += () => Debug.Log($"{missionConfig.MissionName} - взяли контрольную точку.");
        mission.OnFinished += () =>
        {
            Debug.Log($"{missionConfig.MissionName} - миссия завершнена.");
            Object.Destroy(missionPrefab);
            StartNextMission();
        };

        mission.Start();
    }
}