using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitCountExample : MonoBehaviour
{
    [SerializeField] private int hitCount; 

    // Start is called before the first frame update
    void Start()
    {
        hitCount = 0;        
    }

    private void OnMouseDown()
    {
        hitCount++;
    }
}
