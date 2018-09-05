using System;
using System.Collections;
using System.Collections.Generic;

namespace Interfaces.Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task5_1
            //List<IFlyable> flyObject = new List<IFlyable>();

            //Bird fBird = new Bird();
            //flyObject.Add(fBird);
            //Bird sBird = new Bird();
            //flyObject.Add(sBird);
            //Bird tBird = new Bird();
            //flyObject.Add(tBird);

            //Plane fPlane = new Plane();
            //flyObject.Add(fPlane);
            //Plane sPlane = new Plane();
            //flyObject.Add(sPlane);
            //Plane tPlane = new Plane();
            //flyObject.Add(tPlane);

            //foreach (var flyObj in flyObject)
            //{
            //    flyObj.Fly();
            //}
            #endregion

            #region Task5_2
            //int index = 0;
            //List<int> myColl = new List<int>();
            //ArrayList myCollAL = new ArrayList();

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write($"Enter {i + 1} value(int): ");
            //    string val = Console.ReadLine();
            //    myColl.Add(int.Parse(val));
            //    myCollAL.Add(int.Parse(val));
            //}

            //Console.WriteLine("\nPosition(s) (-10) in the List");

            //for (int i = 0; i < myColl.Count; i ++)
            //{
            //    if (myColl[i] == -10)
            //    {
            //        Console.Write("    {0}", i);
            //    }
            //}
            //Console.WriteLine("\nPosition(s) (-10) in the ArraList");
            //for (int i = 0; i < myCollAL.Count; i++)
            //{
            //    if ((int)myCollAL[i] == -10)
            //    {
            //        Console.Write("     {0}", i);
            //    }
            //}

            //myColl.Insert(2, 1);
            //myColl.Insert(8, -3);
            //myColl.Insert(5, -4);
            //Console.WriteLine("\nDispleyed List after insert");
            //Display(myColl);

            //myCollAL.Insert(2, 1);
            //myCollAL.Insert(8, -3);
            //myCollAL.Insert(5, -4);
            //Console.WriteLine("\nDispleyed ArrayList  after insert");
            //Display(myCollAL);

            //for (int i = myColl.Count - 1; i >= 0; i--)
            //{
            //    if (myColl[i] > 20)
            //    {
            //        myColl.Remove(myColl[i]);
            //    }
            //}

            //for (int i = myCollAL.Count - 1; i >= 0; i--)
            //{
            //    if ((int)myCollAL[i] > 20)
            //    {
            //        myCollAL.Remove(myCollAL[i]);
            //    }
            //}

            //Console.WriteLine("\nDispleyed List after remove value greater than 20");
            //Display(myColl);
            //Console.WriteLine("\nDispleyed ArrayList after remove value greater than 20");
            //Display(myCollAL);


            //Console.WriteLine("\nPress any key...");
            //Console.ReadKey();
            #endregion

            #region HomeWork5_1
            //List<IDeveloper> newDevelop = new List<IDeveloper>();

            //Programer newProgramer1 = new Programer();
            //newDevelop.Add(newProgramer1);
            //Programer newProgramer2 = new Programer();
            //newDevelop.Add(newProgramer2);
            //Programer newProgramer3 = new Programer();
            //newDevelop.Add(newProgramer3);

            //Builder newBuilder1 = new Builder();
            //newDevelop.Add(newBuilder1);
            //Builder newBuilder2 = new Builder();
            //newDevelop.Add(newBuilder2);
            //Builder newBuilder3 = new Builder();
            //newDevelop.Add(newBuilder3);

            //foreach (var build in newDevelop)
            //{
            //    build.Tool = "newtool";
            //    build.Create();
            //    build.Destroy();
            //}
            #endregion

            #region HomeWork5_2
            //Dictionary<uint, string> newDictObject = new Dictionary<uint, string>();

            //Console.WriteLine("Add 7 values");
            //for (int i = 0; i < 7; i++)
            //{
            //    Console.Write($"\nAdd {i + 1} ID(int): ");
            //    string idStr = Console.ReadLine();
            //    Console.Write($"\nAdd {i + 1} values(string): ");
            //    string value = Console.ReadLine();
            //    newDictObject.Add(uint.Parse(idStr), value);
            //}

            //Console.Write($"\nEnter user ID for Display info: ");
            //string id = Console.ReadLine();
            //uint idDigit = uint.Parse(id);

            //if (newDictObject.ContainsKey(idDigit))
            //{
            //    Console.WriteLine(newDictObject[idDigit]);
            //}

            //Console.WriteLine("\nPress any key...");
            //Console.ReadKey();
            #endregion
        }

        static void Display(IEnumerable values)
        {
            foreach (int value in values)
            {
                Console.Write($"    {value}");
            }
        }
    }
}
