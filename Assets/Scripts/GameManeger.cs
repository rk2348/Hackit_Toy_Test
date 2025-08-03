using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManeger : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI timeText;//UI�ɕ\������e�L�X�g
    [SerializeField]
    private float startTime;//����

    private void Update()
    {
        startTime -= Time.deltaTime;

        if (startTime < 0)
        {
            startTime = 0;
        }

        timeText.text = startTime.ToString("F0");//�c�莞�Ԃ𐮐��ŕ\������
    }
}