using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    [SerializeField] float projectileSpeed = 1f;
    [SerializeField] float projectileDamage = 80f;

   
    void Update()
    {
        transform.Translate(Vector2.right * projectileSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var health = collision.GetComponent<Health>();
        var attacker = collision.GetComponent<Attacker>();

        if(attacker && health)
        {
            health.DealDamage(projectileDamage);
            Destroy(gameObject);
        }

    }
}
