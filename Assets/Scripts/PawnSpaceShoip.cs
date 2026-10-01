using UnityEngine;

public class PawnSpaceShoip : Pawn
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void Move(Vector3 moveVector)
    {
        transform.position += moveVector;
    }
    public override void Rotate(float angle)
    {
        transform.Rotate(0, 0, angle);
    }
}
