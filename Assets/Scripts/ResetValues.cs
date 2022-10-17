using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetValues : MonoBehaviour
{
    [SerializeField] SOFloat deaths;
    void Start()
    {
        deaths.Value = 0;
    }
}
