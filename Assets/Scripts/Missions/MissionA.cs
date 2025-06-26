using UnityEngine;

public class MissionA : BaseMission
{
    protected override void Execute()
    {
        Debug.Log("A - Делаю что-то в миссии и подхожу выполнению задания.");
        ReachMissionPoint();
        
        Debug.Log("A - А вот мы и подошли к финишу миссии.");
        Finish();
    }
}
