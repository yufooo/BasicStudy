using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

class MathStudy
{
    public List<int> list1 = new List<int>();
    public int[] arrayList1 = new int[5];
    public int[,] tile1 = new int[3,3];
}
public class PrintStar : MonoBehaviour
{
    public GameObject[] go;
    void Start()
    {
        MathStudy ms = new MathStudy();
        ms.list1.Add(1000);
        ms.list1.Add(2000);
        foreach (var list in ms.list1)
        {
            //Debug.Log(list + "List�� �����ϰ� ����� list1�Դϴ�.");
        }

        ms.arrayList1[0] = 1;
        ms.arrayList1[1] = 2;
        ms.arrayList1[2] = 3;
        ms.arrayList1[3] = 4;
        ms.arrayList1[4] = 4;

        foreach (var alist in ms.arrayList1)
        {
            //Debug.Log(alist + "ArrayList�� �����ϰ� ����� arrayList1�Դϴ�.");
        }

        //#region MaxMinAverage
        //Debug.Log($"list1�� �ְ��� {ms.list1.Max()}");
        //Debug.Log($"list1�� �ּҰ��� {ms.list1.Min()}");

        //Debug.Log($"arrayList1�� �ְ��� {ms.arrayList1.Max()}");
        //Debug.Log($"arrayList1�� �ּҰ��� {ms.arrayList1.Min()}");

        //Debug.Log($"list1�� ��հ��� {ms.list1.Average()}");
        //Debug.Log($"arrayList1�� ��հ��� {ms.arrayList1.Average()}");

        //Debug.Log((int)ms.arrayList1.Average());
        //#endregion

        //Debug.Log($"3�� �ֳ���? =>{ms.arrayList1.Contains(3)}");
        //Debug.Log($"500�� �ֳ���? =>{ms.list1.Contains(500)}");

        //int rand1 = Random.Range(0, go.Length);
        //Instantiate(go[rand1], go[rand1].transform.position, Quaternion.identity);


        for (int i = 0; i < ms.tile1.GetLength(0); i++)
        {
            for (int j = 0; j < ms.tile1.GetLength(1); j++)
            {
                ms.tile1[i, j] = Random.Range(0, 2);
            }

        }

        string str = "";

        for (int i = 0; i < ms.tile1.GetLength(0); i++)
        {
            for (int j = 0; j < ms.tile1.GetLength(1); j++)
            {
                if (ms.tile1[i, j] == 0)
                {
                    Instantiate(go[0], new Vector3(i, j, 0), Quaternion.identity);
                }
                else
                {
                    Instantiate(go[1], new Vector3(i, j, 0), Quaternion.identity);
                }
                
               
            }
            //str += ("\n");
        }

        //Debug.Log(str);

    }

}