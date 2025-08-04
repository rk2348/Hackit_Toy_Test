using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    [SerializeField] private float countdownTime = 5f;
    [SerializeField] private Text timeText;

    private float timer;

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
            SceneManager.LoadScene("Result");
        }
    }
}
