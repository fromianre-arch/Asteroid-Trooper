using UnityEngine;
using UnityEngine.InputSystem;

public class MovementPlayer : MonoBehaviour
{
[SerializeField] float MinXValue = -5f;
[SerializeField]  float MaxXValue = 5f;
[SerializeField]  float MinYValue = -2.5f;
[SerializeField]  float MaxYValue = 2.5f;

public KeyCode TeleportKey = KeyCode.Space; //Ablity Key

public GameObject PlayerShip;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
  {
    

  }
    // Update is called once per frame
    void Update()
    {
       // OnKeypress(GetKeyinput());
  if (Input.GetKeyDown(TeleportKey))
        {
           PlayerShip.transform.position = new Vector3(Random.Range(MinXValue, MaxXValue), Random.Range(MinYValue, MaxYValue), 0f);
        }
    }
}


