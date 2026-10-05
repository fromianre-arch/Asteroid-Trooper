using UnityEngine;

public class AsteroidBreak : MonoBehaviour
{
    public float astroidSize;
    public float minSize = 0.25f;
    public GameObject astroidPrefab;
    public int breakCount = 2;
    public bool broken = false;
    private Death death;

    void Start()
    {
        death = GetComponent<Death>();
        astroidSize = gameObject.transform.localScale.x;
    }
    
    public void Break()
    {
        if (broken) return;   // guards against two bullets killing it in the same frame
        broken = true;

        if (astroidSize > minSize)
        {
            Health myHealth = GetComponent<Health>();
            int childMaxHealth = (myHealth != null) ? Mathf.Max(1, myHealth.maxHealth / 2) : 0;
            float childSize = astroidSize / 2f;

            for (int i = 0; i < breakCount; i++)
            {
                GameObject newAstroid = Instantiate(astroidPrefab, transform.position, Quaternion.identity);
                newAstroid.transform.localScale = new Vector3(childSize, childSize, childSize);

                AsteroidBreak newAstroidScript = newAstroid.GetComponent<AsteroidBreak>();
                if (newAstroidScript != null)
                {
                    newAstroidScript.astroidPrefab = astroidPrefab;
                    newAstroidScript.astroidSize = childSize;
                }

                // Set before the child's Start() runs, so it starts at this value.
                Health childHealth = newAstroid.GetComponent<Health>();
                if (childHealth != null && childMaxHealth > 0)
                {
                    childHealth.maxHealth = childMaxHealth;
                }
            }
        }
    }
    // void OnTriggerEnter2D(Collider2D other)
    // {
    //    // Check if the colliding object is a bullet
    //    if (other.CompareTag("Bullet"))
    //     {
    //         // Only break if asteroid is large enough
    //         if (astroidSize > minSize && broken != true)
    //         {
    //            // Create smaller asteroids
    //            for (int i = 0; i < breakCount; i++)
    //             {                                                                                                                                                
    //                 // Calculate random direction for each new asteroid                                                                                          
    //                 float angle = Random.Range(0f, 360f);                                                                                                        
    //                 Vector3 direction = new Vector3(Mathf.Sin(angle * Mathf.Deg2Rad), Mathf.Cos(angle * Mathf.Deg2Rad),0f);
    //                 // Instantiate smaller asteroid
    //                 GameObject newAstroid = Instantiate(astroidPrefab, transform.position, Quaternion.identity);
                    
    //                 Health childHealth = newAstroid.GetComponent<Health>();
    //                 if (childHealth.currHealth != null && childHealth.maxHealth > 0)
    //                 {
    //                     childHealth.maxHealth = childHealth.currHealth;
    //                 }
    //                AsteroidBreak newAstroidScript = newAstroid.GetComponent<AsteroidBreak>();                                                                       
    //                if (newAstroidScript != null)                                                                                                                    
    //                {                                                                                                                                                
    //                    newAstroidScript.astroidPrefab = this.astroidPrefab; // This is the key fix                                                                  
    //                    newAstroidScript.astroidSize = astroidSize / 2f;                                                                                             
    //                    newAstroid.transform.localScale = new Vector3(astroidSize / 2f, astroidSize / 2f, astroidSize / 2f);
    //                    newAstroidScript.broken = true;
    //                }
    //             }
    //         }

    //        // Destroy the original asteroid
    //        death.Die();
    //     }
    // }
}