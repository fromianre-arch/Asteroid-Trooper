using UnityEngine;

public class DeathDelete : Death
{
    public override void Die()
    {
        base.Die();

        Destroy(gameObject);
    }
}
