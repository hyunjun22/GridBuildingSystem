using UnityEngine;
using UnityEngine.InputSystem;


public class BuildingManager : MonoBehaviour
{
    [SerializeField] GameObject HousePrefab;


    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            PlaceBuilding();
        }
    }

    void PlaceBuilding()
    {
        Vector2 mousePosition = Mouse.current.position.ReadValue();

        Ray ray = Camera.main.ScreenPointToRay(mousePosition);

        if(Physics.Raycast(ray, out RaycastHit hitInfo))
        {
            Vector3 position = hitInfo.point;

            Instantiate(HousePrefab, position, Quaternion.identity);

            Debug.Log("House Placed at: " + position);
        }
    }
}
