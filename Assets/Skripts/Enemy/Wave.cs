using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    public List<GameObject> enenies;

    private void Update()
    {
        if(enenies.Count == 0)
        {
            Destroy(gameObject);
        }
        else if(enenies[0] == null)
        {
            enenies.RemoveAt(0);
        }
    }
}
