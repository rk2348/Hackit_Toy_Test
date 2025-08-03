using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    [SerializeField] private float Time = 5f;

    void Start()
    {
        // 5•bŒã‚ÉResult‚Ö
        Invoke("GoToResult", Time);
    }

    // Update is called once per frame
    void GoToResult()
    {
        SceneManager.LoadScene("Result");
    }
}
