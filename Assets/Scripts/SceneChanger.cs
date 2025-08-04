using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    public Animator buttonAnimator;      // ← アニメーション再生用
    public float animationDelay = 0.5f;  // ← アニメーション再生時間

    private string nextSceneName;

    public void ChangeToScene(string sceneName)
    {
        nextSceneName = sceneName;

        // アニメーション再生（Trigger "Pressed" を送る）
        if (buttonAnimator != null)
        {
            buttonAnimator.SetTrigger("Pressed");
        }

        // 一定時間待ってからシーン遷移
        Invoke(nameof(LoadScene), animationDelay);
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
