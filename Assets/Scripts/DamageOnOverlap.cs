using UnityEngine;

public class DamageOnOverlap : MonoBehaviour
{
    public float damageAmount = -10f;

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

    otherHeath = otherCollider.GetComponent<Health>();
      
    }
}
