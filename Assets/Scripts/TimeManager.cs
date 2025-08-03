using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    [SerializeField] private float countdownTime = 5f;
    [SerializeField] private Text timeText;

    private float timer;
    public static float timeResult;  // �� �����ň����p��

    void Start()
    {
        timer = countdownTime;
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer > 0f)
        {
            timeText.text = "Time: " + Mathf.Ceil(timer).ToString();
        }
        else
        {
            timeResult = countdownTime;  // �� �����ݒ肳�ꂽ���Ԃ��L�^
            SceneManager.LoadScene("Result");
        }
    }
}
