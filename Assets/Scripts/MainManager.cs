using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 5�b���Result��
        Invoke("GoToResult", 5f);
    }

    // Update is called once per frame
    void GoToResult()
    {
        SceneManager.LoadScene("Result");
    }
}
