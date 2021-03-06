using System;
using UnityEngine;

public class Controller : MonoBehaviour
{
    #region GemaLoop
    private void Awake()
    {
        Matimatick();
        Loop();
        Massiv();
        Manymass();
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

    private void Massiv()
    {
        int[] mas = new int[5];
        mas[0] = 44;
        mas[1] = 999;
        mas[2] = 1111;
        mas[3] = 33333;
        mas[4] = 1;
        Debug.Log(mas[2]);

        Debug.Log("Перебор массива с foreach");
        foreach (int i in mas)
        {
            Debug.Log(i);
        }

        Debug.Log("Перебор массива с for");
        for (int i = 0; i < mas.Length; i++)
        {
            Debug.Log(mas[i]);
        }
    }

    private void Manymass()
    {
        int[,] mas = new int[2, 4] { { 44, 55, 66, 77 }, { 11, 22, 33, 88, } };
        foreach (int i in mas)
        {
            Debug.Log(i);
        }

        int[,] mMasiv = { { 14, 13, 12, 11, 10 }, { 9, 8, 7, 6, 5 }, { 4, 3, 2, 1, 0 } };
        foreach(int i in mMasiv)
        {
            Debug.Log(i);
        }
        
    }
    #endregion
}

