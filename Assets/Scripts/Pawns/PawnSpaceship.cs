//Course: GPE104 
//Prof: Matthew Henry
//Student: Chad V

using UnityEngine;

public class PawnSpaceship : Pawn
{

    public float moveSpeed = 3;
    public float turnSpeed = 180;
    public Transform tf;
    private Shooter sh;
    private ScreenWrap screenWrapComponent;


    void LateUpdate()
    {
       // Handle screen wrapping if component exists                                                                                                            
       if (screenWrapComponent != null)                                                                                                                         
       {                                                                                                                                                        
           screenWrapComponent.HandleWrap();                                                                                                                    
       }
    }
    // move transform by some Vector3 * moveSpeed * Time.deltaTime.
    public override void Move(Vector3 someVec3)
    {
        tf.position += someVec3 * moveSpeed * Time.deltaTime;
    }

    // rotate by some angle
    public override void Rotate(float someAngle)
    {
        tf.Rotate(0,0,someAngle * turnSpeed * Time.deltaTime);
    }

    // teleport to some vector3
    public override void Teleport(Vector3 targetPosition)
    {
        tf.position = targetPosition;
    }

    // shoot our projectile
    public override void Shoot()
    {
        //shoot
        if (sh != null)
        {
            sh.Shoot();
        }
    }

    // on start get ref to Transform and Shooter. 
    public override void Start()
    {
        tf = GetComponent<Transform>();
        sh = GetComponent<Shooter>();
        screenWrapComponent = GetComponent<ScreenWrap>(); 
    }
}
