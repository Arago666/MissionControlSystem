using System;
using UnityEngine;

public abstract class BaseMission : MonoBehaviour, IMission
{
    public event Action OnStarted;
    public event Action OnMissionPointReached;
    public event Action OnFinished;

    void IMission.Start()
    {
        OnStarted?.Invoke();
        Execute();
    }

    protected abstract void Execute();

    protected void ReachMissionPoint() => OnMissionPointReached?.Invoke();

    protected void Finish() => OnFinished?.Invoke();
}
