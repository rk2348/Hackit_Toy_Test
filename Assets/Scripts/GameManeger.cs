using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManeger : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI timeText;//UIに表示するテキスト
    [SerializeField]
    private float startTime;//時間

    private void Update()
    {
        startTime -= Time.deltaTime;

        if (startTime < 0)
        {
            startTime = 0;
        }

        timeText.text = startTime.ToString("F0");//残り時間を整数で表示する
    }
}