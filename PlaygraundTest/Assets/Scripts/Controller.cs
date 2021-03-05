using System;
using UnityEngine;

public class Controller : MonoBehaviour
{
    #region GemaLoop
    private void Awake()
    {
        Matimatick();
        Loop();
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

    #region Memori
    private void Matimatick()
    {
        var a = 5;
        var b = 9;
        var c = a;
        c += a + b;

        Debug.Log($"{a}+{a}+{b}={c}");
    }

    private void Loop()
    {
        Debug.Log("\nFor\n");
        int i = 1;
        for (; i < 5; i++)
        {
            {
                Debug.Log($"Выпил бутылок {i}");
            }
        }

        Debug.Log("\nDo\n");
        do
        {
            Debug.Log($"Выпил бутылок {i}");
            i++;
        }
        while (i < 10);

        Debug.Log("\nWhile\n");
        int t = 5;
        while (t > 0)
        {
            Debug.Log(t);
            t--;
        }

        Debug.Log("\nBreak\n");
        for (int b = 1; b < 100; b++)
        {
            Debug.Log($"Проценты Лукашенко {b}% = 100%");
            if (b == 3)
                break;
            Debug.Log("Змагары на помащ");
        }

        Debug.Log("\nContinue\n");
        for (int b = 1; b < 10; b++)
        {
            if (b == 3)
                continue;
            Debug.Log(b);
        }

    }
    #endregion
}

