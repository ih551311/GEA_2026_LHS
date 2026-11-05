using UnityEngine;

public class HpPractice : MonoBehaviour
{
    public int currentHp = 7;
    public int maxHp = 10;

    [ContextMenu("체력")]
    void PrintHp()
    {
        // float로 먼저 변환해 소수점 나눗셈을 한 뒤 100을 곱하고 int로 변환
        int a = (int)((float)currentHp / maxHp * 100);
        Debug.Log("HP " + a + "%");
    }
}