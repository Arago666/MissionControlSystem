using UnityEngine;

public class MissionC : BaseMission
{
    protected override void Execute()
    {
        Debug.Log("C - Делаю что-то в миссии и подхожу выполнению задания.");
        ReachMissionPoint();
        
        Debug.Log("C - А вот мы и подошли к финишу миссии.");
        Finish();
    }
}
