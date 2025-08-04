using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    public Animator buttonAnimator;      // �� �A�j���[�V�����Đ��p
    public float animationDelay = 0.5f;  // �� �A�j���[�V�����Đ�����

    private string nextSceneName;

    public void ChangeToScene(string sceneName)
    {
        nextSceneName = sceneName;

        // �A�j���[�V�����Đ��iTrigger "Pressed" �𑗂�j
        if (buttonAnimator != null)
        {
            buttonAnimator.SetTrigger("Pressed");
        }

        // ��莞�ԑ҂��Ă���V�[���J��
        Invoke(nameof(LoadScene), animationDelay);
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
