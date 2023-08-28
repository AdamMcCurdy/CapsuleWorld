using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject activeObject;
    public Vector3 cameraOffset;
    private Camera cam;
    public float speed;

    void Start()
    {
        cam = Camera.main;
    }

    public void ChangePlayer(GameObject gameObject)
    {
        activeObject = gameObject;
    }

    void Update()
    {
        if (activeObject)
        {
            Vector3 destination = activeObject.transform.position + cameraOffset;
            cam.transform.position = Vector3.Lerp(cam.transform.position, destination, Time.deltaTime * speed);
        }
    }
}