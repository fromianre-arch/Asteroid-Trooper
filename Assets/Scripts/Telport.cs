using UnityEngine;

// public/Private = access modifier 
// Data type = the type of value stored (int, float, string, etc.)
// Variable name = the identifier used to access the variable


public class Telport : MonoBehaviour
{
    public KeyCode TeleportKey;

    public float MinX;
    public float MaxX;
    public float MinY;
    public float MaxY;

    public Transform tf;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    
    // if (keyboard.current[Key.P].wasPressedThisFrame)
    {
        //Transform tf;
        //tf = GetComponent<Transform>();
        //tf.localScale = new Vector3(Random.Range(1, 5), Random.Range(1, 5), Random.Range(1, 5));
        {
            if (Input.GetKey(TeleportKey))
            {
            tf.position = new Vector3(Random.Range(MinX, MaxX), Random.Range(MinY, MaxY));
            }
        }
    }
}
 