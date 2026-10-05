using UnityEngine;

public class ScreenWrap : MonoBehaviour                                                                                                                          
{
    public float screenWrapBuffer = 1f;

    private float screenBottom;
    private float screenTop;
    private float screenLeft;
    private float screenRight;
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
        SetScreenBoundaries();
    }
    //set screen boundrys
    void SetScreenBoundaries()
    {
    if (mainCamera != null)
        {
           Vector3 bottomLeft = mainCamera.ScreenToWorldPoint(new Vector3(0, 0, mainCamera.nearClipPlane));
           Vector3 topRight = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, mainCamera.nearClipPlane));

           screenLeft = bottomLeft.x - screenWrapBuffer;
           screenRight = topRight.x + screenWrapBuffer;
           screenBottom = bottomLeft.y - screenWrapBuffer;
           screenTop = topRight.y + screenWrapBuffer;
        }
   }

    public void HandleWrap()
    { 
        Vector3 currentPosition = transform.position;

        // Wrap horizontally
        if (currentPosition.x > screenRight)
        {
           transform.position = new Vector3(screenLeft, currentPosition.y, currentPosition.z);
        }
        else if (currentPosition.x < screenLeft)
        {
           transform.position = new Vector3(screenRight, currentPosition.y, currentPosition.z);
        }

        // Wrap vertically
        if (currentPosition.y > screenTop)
        {
           transform.position = new Vector3(currentPosition.x, screenBottom, currentPosition.z);
        }
        else if (currentPosition.y < screenBottom)
        {
           transform.position = new Vector3(currentPosition.x, screenTop, currentPosition.z);
        }
    }
}