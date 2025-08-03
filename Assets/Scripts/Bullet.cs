using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int scoreValue = 100;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;

        // 5�b��Ɏ����ō폜�i�G�ɓ�����Ȃ��Ă��j
        Destroy(gameObject, 5f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // �X�R�A���Z
            ScoreManager.Instance.AddScore(scoreValue);

            // �G���폜
            Destroy(collision.gameObject);

            Destroy(gameObject);
        }
    }
}
