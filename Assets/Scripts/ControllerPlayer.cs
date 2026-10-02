
// Using give you the ablity to use the Unity Core Engine
using UnityEngine; 
using UnityEngine.InputSystem;

public class ControllerPlayer : Controller
{
    public Key moveforward;   
    public Key movebackward;
    public Key moveleft;
    public Key moveright;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Keyboard.current[movebackward].isPressed)
        {
            pawn.Move(Vector3.back * Time.deltaTime);
        }
        
        
        if (Keyboard.current[moveleft].isPressed)
        {
            pawn.Move(Vector3.left * Time.deltaTime);
        }
        
        
        if (Keyboard.current[moveright].isPressed)
        {
            pawn.Move(Vector3.right * Time.deltaTime);
        }
       
       
        if (Keyboard.current[moveforward].isPressed)
        {
            pawn.Move(Vector3.forward * Time.deltaTime);
        }

        
    }
}
