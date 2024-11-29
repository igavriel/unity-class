using UnityEngine;
using System.Collections.Generic;

public class RoadDrawer : MonoBehaviour
{
    public GameObject roadPrefab;
    public float roadSpacing = 1f;
    public LayerMask planeLayer;

    private List<Vector3> roadPoints = new List<Vector3>();
    private bool isDrawing = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartDrawing();
        }
        else if (Input.GetMouseButton(0) && isDrawing)
        {
            ContinueDrawing();
        }
        else if (Input.GetMouseButtonUp(0) && isDrawing)
        {
            FinishDrawing();
        }
    }

    void StartDrawing()
    {
        roadPoints.Clear();
        isDrawing = true;
        AddPoint();
    }

    void ContinueDrawing()
    {
        if (Vector3.Distance(roadPoints[roadPoints.Count - 1], GetMouseWorldPosition()) > roadSpacing)
        {
            AddPoint();
        }
    }

    void FinishDrawing()
    {
        isDrawing = false;
        GenerateRoad();
    }

    void AddPoint()
    {
        Vector3 point = GetMouseWorldPosition();
        if (point != Vector3.zero)
        {
            roadPoints.Add(point);
        }
    }

    Vector3 GetMouseWorldPosition()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, planeLayer))
        {
            return hit.point;
        }

        return Vector3.zero;
    }

    void GenerateRoad()
    {
        for (int i = 0; i < roadPoints.Count - 1; i++)
        {
            Vector3 start = roadPoints[i];
            Vector3 end = roadPoints[i + 1];
            Vector3 direction = (end - start).normalized;

            GameObject roadSegment = Instantiate(roadPrefab, start, Quaternion.identity);
            roadSegment.transform.forward = direction;
            roadSegment.transform.localScale = new Vector3(1, 1, Vector3.Distance(start, end));
        }
    }
}