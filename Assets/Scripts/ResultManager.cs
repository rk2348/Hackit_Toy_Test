using UnityEngine;
using UnityEngine.UI;

public class ResultManager : MonoBehaviour
{
    [SerializeField] private Text resultTimeText;

    void Start()
    {
        resultTimeText.text = "Time: " + Mathf.Ceil(TimeManager.timeResult).ToString();
    }
}
