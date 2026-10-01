using UnityEngine;

public abstract class Pawn : MonoBehaviour
{
    
 public Controller controller;

 public abstract void Move(Vector3 moveVector);
 public abstract void Rotate(float angle);


}
