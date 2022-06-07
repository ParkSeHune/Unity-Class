using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    //�ڷᱸ�� Queue : ���� ���� ���� �����Ͱ� ���� ���� ������ ����.

    public static ObjectPool objpool;

    //������Ʈ Ǯ�� ���� ���� ������Ʈ�� �����մϴ�.
    public GameObject prefab;

    //���� ������Ʈ�� ���� �� �ִ� �ڷᱸ�� Queue ����
    public Queue<GameObject> queue = new Queue<GameObject>();


    void Start()
    {
        objpool = this;

        for (int i = 0; i < 10; i++)
        {   //                                                 ��ǥ                   ȸ��
            GameObject tempPrefab = Instantiate(prefab, new Vector3(0, 5, 0), Quaternion.identity);
             queue.Enqueue(tempPrefab);
            tempPrefab.gameObject.SetActive(false);
        }
    }

    public void InsertQueue(GameObject pobj)
    {
        queue.Enqueue(pobj);
        pobj.gameObject.SetActive(false);
    }

    public GameObject GetQueue()
    {
        GameObject tempPrefab = queue.Dequeue();
        tempPrefab.gameObject.SetActive(true);

        return tempPrefab;
    }
}
