using System.Xml.Schema;
using UnityEditor.UIElements;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
[SerializeField] float MinXValue = -5f;
[SerializeField]  float MaxXValue = 5f;
[SerializeField]  float MinYValue = -2.5f;
[SerializeField]  float MaxYValue = 2.5f;

public KeyCode TeleportKey;
public Transform TelPlayer;
public GameObject PlayerShip;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      TelPlayer = GetComponent<Transform>();
    }



    // Update is called once per frame
    void Update()
    {
       // OnKeypress(GetKeyinput());
       if (Input.GetKeyDown(TeleportKey))
        {
           TelPlayer.position = new Vector3(Random.Range(MinXValue, MaxXValue), Random.Range(MinYValue, MaxYValue), 0f);
        }
    }
}
