using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private Transform target;
    public float speed = 3f;
    //public float point;

    private int scoreValue = -100;


    public void SetTarget(Transform targetTransform)
    {
        target = targetTransform;
    }

    private void Update()
    {
        if (target == null) return;

        Vector3 direction = (target.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;
    }

    //“G‚ÆƒvƒŒƒCƒ„[‚ª“–‚½‚Á‚½‚ç“G‚ÌPrefab‚ğÁ‚·
    private void OnCollisionEnter(Collision collion)
    {
        if (collion.gameObject.CompareTag("Player"))
        {
            ScoreManager.Instance.AddScore(scoreValue);

            Destroy(this.gameObject);
        }
    }
}