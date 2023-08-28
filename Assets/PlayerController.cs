using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject activeObject;
    public CameraController cc;

    [SerializeField] private Vector3 speedMultiplier = new Vector3(1, 1, 1);
    private Vector3 movementVector = Vector3.zero;

    void Start()
    {
        cc = GetComponent<CameraController>();
    }

    public void SetActiveObject(GameObject gameObject)
    {
        activeObject = gameObject;
        cc.ChangePlayer(gameObject);
    }

    void Update()
    {
        if (activeObject)
        {
            movementVector = Vector3.zero;

            movementVector.x = Input.GetAxis("Horizontal");
            movementVector.z = Input.GetAxis("Vertical");

            Vector3 newVector = Vector3.Scale(movementVector.normalized, speedMultiplier);
            activeObject.transform.Translate(newVector, Space.World);
        }
    }
}