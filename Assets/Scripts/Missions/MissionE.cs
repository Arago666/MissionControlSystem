using UnityEngine;
using System.Collections;

public class MissionE : BaseMission
{
    protected override void Execute()
    {
        StartCoroutine(RunMission());
    }
    
    private IEnumerator RunMission()
    {
        Debug.Log("E - Делаю что-то в миссии и подхожу выполнению задания.");
        ReachMissionPoint();

        yield return new WaitForSeconds(5f);

        Debug.Log("E - А вот мы и подошли к финишу миссии.");
        Finish();
    }
}
