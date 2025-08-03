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

        // 5•bŒã‚É©“®‚Åíœi“G‚É“–‚½‚ç‚È‚­‚Ä‚àj
        Destroy(gameObject, 5f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // ƒXƒRƒA‰ÁZ
            ScoreManager.Instance.AddScore(scoreValue);

            // “G‚ğíœ
            Destroy(collision.gameObject);

            Destroy(gameObject);
        }
    }
}
