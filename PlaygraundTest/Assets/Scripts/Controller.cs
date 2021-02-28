using System;
using UnityEngine;

public class Controller : MonoBehaviour
{
    #region GemaLoop
    private void Awake()
    {
        Matimatick();
    }

    private void OnEnable()
    {
        
    }

    private void Start()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    private void Update()
    {
       
    }

    private void LateUpdate()
    {
        
    }
    #endregion

    private void Matimatick()
    {
        var a = 5;
        var b = 9;
        var c = a;
        c +=a + b;

        Debug.Log($"{a}+{a}+{b}={c}");
    }
}
