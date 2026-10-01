using UnityEngine;
using UnityEngine.InputSystem;

public class QuitOnExcape: MonoBehaviour 


{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
       if (Keyboard.current[Key.Escape].wasPressedThisFrame)
        {
       Application.Quit();
        }
    }
}
