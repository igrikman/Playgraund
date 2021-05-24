using System;
using UnityEngine;
namespace Assets.Scripts
{
    public partial class Controller : MonoBehaviour
    {
        #region GemaLoop
        private void Awake()
        {
            
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
            foreach (int i in mMasiv)
            {
                Debug.Log(i);
            }

        }
        #endregion

        #region HomeTask 

        #region VirtualReg
        private void Virtual()
        {
            Man sport = new Man("Billy", "-Hey buddy, I think you've got the wrong door, the leather club is two blocks down.");
            Man leather = new Man("Leather man", "- Fuck you.");

            sport.Display();
            leather.Display();

        }
        class Gachi
        {
            public string Name { get; set; }
            public Gachi(string name)
            {
                Name = name;
            }
            public virtual void Display()
            {
                Debug.Log(Name);
            }
        }

        class Man : Gachi
        {
            public string Say { get; set; }
            public Man(string name, string say) : base(name)
            {
                Say = say;
            }
            public override void Display()
            {
                Debug.Log($"{Name} say {Say}");
            }
        }
        #endregion

        #region AbstraktReg
        private void Abstrakt()
        {
            GoodBoy dog1 = new GoodBoy("Vetsuta", "Sоn of a dog");
            BadBoy dog2 = new BadBoy("Kaha", 5);

            dog1.PrintGB();
            dog2.PrintBB();
        }

        abstract class Dog
        {
            public string Name { get; set; }
            public Dog(string name)
            {
                Name = name;
            }
            public void Print()
            {
                Debug.Log(Name);
            }

        }
        class GoodBoy : Dog
        {
            public string Say { get; set; }
            public GoodBoy(string name, string say) : base(name)
            {
                Say = say;
            }
            public void PrintGB()
            {
                Debug.Log($"{Name} do it {Say}");
            }
        }

        class BadBoy : Dog
        {
            public int Shit { get; set; }
            public BadBoy(string name, int shit) : base(name)
            {
                Shit = shit;
            }
            public void PrintBB()
            {
                Debug.Log($"{Name} do it {Shit} crap");
            }
        }
        #endregion

        #region interfaceReg


        public void Inter()
        {
            IPut you = new Clen("Igor");
            you.Suka();

        }
        interface IPut
        {
            string Name { get; set; }

            void Suka();
        }
        class Clen : IPut
        {

            public string Name { get; set; }

            public Clen(string name)
            {
                Name = name;
            }

            public void Suka()
            {
                Debug.Log($"{Name} заебался идти блядь...");
            }


        }

        #endregion


        #region DragonLore
        public enum ElementalEnum
        {
            Water = 1,
            Fire,
            Earth,
            Air
        }

        public enum Weapon
        {
            Sword,
            Canoon,
            Tool
        }
        private static void TestMdragon()
        {
            Debug.Log("Воздух");

            AirDragon a = new AirDragon();
            a.EasyCast();
            a.MidlCast();
            a.HardCast();

            Debug.Log("Земля");

            EartheDragon e = new EartheDragon();
            e.EasyCast();
            e.MidlCast();
            e.HardCast();

            Debug.Log("Вода");

            WaterDragon w = new WaterDragon();
            w.EasyCast();
            w.MidlCast();
            w.HardCast();

            Debug.Log("Огонь");

            FireDragon f = new FireDragon();
            f.EasyCast();
            f.MidlCast();
            f.HardCast();

        }

        private static void TestMMdragon()
        {
            PlatinumDragon p = new PlatinumDragon();
            p.EasyCast();
            p.MidlCast();
            p.HardCast();
        }


        private static void TestLor()
        {

            Lizzard.Read();
            Dragon.Read();
            FlyDragon.Read();



        }


        #endregion
        #endregion
    }
}




