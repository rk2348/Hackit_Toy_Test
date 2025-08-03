using UnityEngine;

public class Firing : MonoBehaviour
{
    [SerializeField] private GameObject Bullet;
    [SerializeField] private float bulletSpeed = 20f;

    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        FiringAction();
    }

    void FiringAction()
    {
        if ((Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) && Input.GetMouseButtonDown(0))
        {
            // �J�����̈ʒu�ƌ����Ő���
            GameObject newBullet = Instantiate(Bullet, mainCamera.transform.position, mainCamera.transform.rotation);

            // Rigidbody�őO���ɑ��x��^����
            Rigidbody rb = newBullet.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = mainCamera.transform.forward * bulletSpeed;
            }

            // 5�b��ɍ폜
            Destroy(newBullet, 5f);
        }
    }
}
