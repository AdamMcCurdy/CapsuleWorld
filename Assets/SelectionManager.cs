using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    private PlayerController pc;
    [SerializeField] private Camera cam;

    void Start()
    {
        pc = GetComponent<PlayerController>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hitInfo) && hitInfo.transform.gameObject.CompareTag("Player"))
            {
                pc.SetActiveObject(hitInfo.transform.gameObject);
            }
        }
    }
}