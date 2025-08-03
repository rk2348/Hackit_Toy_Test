using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour
{
    [SerializeField] private GameObject Bullet;
    //[SerializeField] private Transform firePoint;  // �e�̔��ˈʒu

    void Update()
    {
        FiringAction();
    }

    void FiringAction()
    {
        // ���V�t�g�L�[��������Ă��āA���N���b�N�������ꂽ�Ƃ�
        if ((Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) && Input.GetMouseButtonDown(0))
        {
            Instantiate(Bullet, transform.position, transform.rotation);
        }
    }
}
