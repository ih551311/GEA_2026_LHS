using UnityEngine;
using TMPro;

public class KillCountUI : MonoBehaviour
{
    public TMP_Text label;

    void Start()
    {
        Health.killCount = 0;
    }

    void Update()
    {
        if (label != null)
        {
            label.text = "KILL " + Health.killCount;
        }
    }
}