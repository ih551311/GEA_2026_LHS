using System.Collections.Generic;
using UnityEngine;

public class BattleLog : MonoBehaviour
{
    public int[] damages = { 1200, 3500, 800, 12000, 3500, 950 };
    public int criticalLine = 3000;

    [ContextMenu("전투 기록")]
    void ShowBattleLog()
    {
        int sum = 0;
        List<int> criticals = new List<int>();

        foreach (int d in damages)
        {
            sum += d;
            if (d >= criticalLine) criticals.Add(d);
        }

        Debug.Log("총 데미지 " + sum);
        Debug.Log("치명타 " + criticals.Count + " 회");
        foreach (int c in criticals) Debug.Log("치명타 " + c);
    }
}