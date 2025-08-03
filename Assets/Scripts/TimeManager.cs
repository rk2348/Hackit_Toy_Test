using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    [SerializeField] private float countdownTime = 5f;
    [SerializeField] private Text timeText;

    private float timer;
    public static float timeResult;  // © ‚±‚±‚Åˆø‚«Œp‚®

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
            timeResult = countdownTime;  // © ‰Šúİ’è‚³‚ê‚½ŠÔ‚ğ‹L˜^
            SceneManager.LoadScene("Result");
        }
    }
}
