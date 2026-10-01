using UnityEngine;

public class Death : MonoBehaviour
{
   public virtual void Die()
    {
        // Default death behavior, can be overridden by subclasses
        Destroy(gameObject);
    }
}
