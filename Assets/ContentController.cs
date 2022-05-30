using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentController : MonoBehaviour
{
    [SerializeField] GameObject buttonNumberPreFab;
    [SerializeField] Transform content;

    [SerializeField] GameObject[] squares;
    [SerializeField] GameObject[] rectangles;
    [SerializeField] GameObject[] circles;
    [SerializeField] GameObject[] triangles;

    private List<int> list;

    public void SpawButton(List<int> arr)
    {
        ClearContent();

        for(int i = 0; i < arr.Count; i++)
        {
            GameObject item = new GameObject();
            if (arr[i] == 0)
            {
                item = Instantiate(squares[Random.Range(0,squares.Length)], Vector3.zero, Quaternion.identity, content);
            }
            else if (arr[i] == 1)
            {
                item = Instantiate(rectangles[Random.Range(0, rectangles.Length)], Vector3.zero, Quaternion.identity, content);
            }
            else if (arr[i] == 2)
            {
                item = Instantiate(circles[Random.Range(0, circles.Length)], Vector3.zero, Quaternion.identity, content);
            }
            else if (arr[i] == 3)
            {
                item = Instantiate(triangles[Random.Range(0, triangles.Length)], Vector3.zero, Quaternion.identity, content);
            }

            item.transform.localPosition = Vector3.zero;
        }
    }

    private void ClearContent()
    {
        for(int i = 0; i < content.childCount; i++)
        {
            Destroy(content.GetChild(i).gameObject);
        }
    }
}
