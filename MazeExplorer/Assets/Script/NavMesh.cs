using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMesh : MonoBehaviour
{
    public NavMeshSurface navMeshSurface;

    private void Start()
    {
        navMeshSurface.BuildNavMesh(); 
    }

    public void UpdateNavMesh()
    {
        navMeshSurface.RemoveData();

        navMeshSurface.AddData();

        navMeshSurface.BuildNavMesh();
    }
}
