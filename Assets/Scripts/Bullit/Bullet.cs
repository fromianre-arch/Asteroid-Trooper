//Course: GPE104 
//Prof: Matthew Henry 
//Student: Chad V

using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    public GameManager someGameManager;
    public float bulletForce = 100;
    private Rigidbody2D rb;
    private Transform tf;
    private Death death;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tf = GetComponent<Transform>();
        death = GetComponent<Death>();

        GameManager.someGameManager.bulletList.Add(this);

        if (rb != null && tf != null)
        {
            rb.AddForce(-tf.up * bulletForce);

            //I wanted to add a deployed projectile like seen in RL with missles, where an initial charge deploys the weapon
            //payload and then the weapon ignites, speeding up. I decided to try and use the coroutine to increase the bulletforce
            // after .3 seconds
            StartCoroutine(ChangeVariableAfterTime());
            // this will ensure we don't run out of memory due to 10000000s of bullets. After 10 seconds the bullet is destroyed.
            StartCoroutine(DestroyAfterTime());
        }

        // after .3 seconds increase bullet force to 500
        IEnumerator ChangeVariableAfterTime()
        {
            // Wait for exactly 3 seconds
            yield return new WaitForSeconds(0.3f);
            Debug.Log("CHANGED Bforce to 500");
            bulletForce = 600;
            rb.AddForce(-tf.up * bulletForce);
        }

        // after 10 seconds destroy bullet.
        IEnumerator DestroyAfterTime()
        {
            yield return new WaitForSeconds(5f);
            Debug.Log($"{this} Bullet has died due to not impacting anything");
            death.Die();
        }
    }
}
