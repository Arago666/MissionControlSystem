using UnityEngine;

public class MissionD : BaseMission
{
    protected override void Execute()
    {
        Debug.Log("D - Делаю что-то в миссии и подхожу выполнению задания.");
        ReachMissionPoint();
        
        Debug.Log("D - А вот мы и подошли к финишу миссии.");
        Finish();
    }
}
