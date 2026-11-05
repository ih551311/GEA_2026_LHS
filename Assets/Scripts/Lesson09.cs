using UnityEngine;

public class Lesson09 : MonoBehaviour
{
    public int gold = 100;
public int potion = 3;
[ContextMenu("골드 보기")]
void ShowGold()
{
    Debug.Log(gold);
}
}
