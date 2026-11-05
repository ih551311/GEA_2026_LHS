using UnityEngine;

public class RewardCalc : MonoBehaviour
{
    public int playSeconds = 3725;
    public int gold = 1234;
    public int members = 4;
    public int kills = 7;
    public int expPerKill = 35;
    public int totalDamage = 250;
    public int hits = 20;

    public float expRate = 1.5f;

    [ContextMenu("정산")]
    void Settle()
    {
        int h = playSeconds / 3600;
        int m = (playSeconds % 3600) / 60;
        int s = playSeconds % 60;
        Debug.Log("플레이 시간: " + h + "시간 " + m + "분 " + s + "초");

        Debug.Log("1인당 골드: " + (gold / members) + " / 남은 골드: " + (gold % members));

        int baseExp = kills * expPerKill;
        int finalExp = (int)(baseExp * expRate);
        Debug.Log("기본 경험치: " + baseExp + " / 최종 경험치: " + finalExp);

        int level = 1 + (finalExp / 100);
        int nextExp = 100 - (finalExp % 100);
        Debug.Log("레벨: " + level + " (다음 레벨까지: " + nextExp + ")");

        Debug.Log("평균 데미지: " + ((float)totalDamage / hits));
    }
}