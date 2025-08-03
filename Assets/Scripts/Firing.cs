using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour
{
    [SerializeField] private GameObject Bullet;
    //[SerializeField] private Transform firePoint;  // 弾の発射位置

    void Update()
    {
        FiringAction();
    }

    void FiringAction()
    {
        // 左シフトキーが押されていて、左クリックが押されたとき
        if ((Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) && Input.GetMouseButtonDown(0))
        {
            Instantiate(Bullet, transform.position, transform.rotation);
        }
    }
}
