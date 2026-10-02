using UnityEngine;
// 
public class DamageOnOverlap : MonoBehaviour
{
    public float damageAmount;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D (Collider2D otherCollider)
    {
        Health otherhealth;
        
        otherhealth = otherCollider.gameObject.GetComponent<Health>();

        if (otherhealth != null)
        {
            otherhealth.TakeDamage(damageAmount);
        }
    }
}
