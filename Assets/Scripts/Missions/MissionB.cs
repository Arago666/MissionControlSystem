using System.Collections;
using UnityEngine;

public class MissionB : BaseMission
{
    protected override void Execute()
    {
        StartCoroutine(RunMission());
    }
    
    private IEnumerator RunMission()
    {
        Debug.Log("B - Делаю что-то в миссии и подхожу выполнению задания.");
        ReachMissionPoint();

        yield return new WaitForSeconds(1f);

        Debug.Log("B - А вот мы и подошли к финишу миссии.");
        Finish();
    }
}
