using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] GameObject tilePrefab;

    [SerializeField] int width = 10;
    [SerializeField] int height = 10;

    void Start()
    {
        CreateGrid();
    }

    void CreateGrid()
    {
        for (int x = 0; x < width; x++)
        {
            for (int z = 0; z < height; z++)
            {
                Vector3 position = new Vector3(x, 0, z);

                Instantiate(tilePrefab, position, Quaternion.identity, transform);
            }
        }
    }
}
