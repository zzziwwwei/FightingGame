using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalManager : MonoBehaviour
{
    public Dictionary<int, GameObject> roles = new();
    void Add(int id)
    {
        roles.Add(id, Instantiate(new GameObject(), transform.position, transform.rotation));
    }
    void Delete(int id)
    {
        roles.Remove(id);
    }
    void Update()
    {

    }
}
