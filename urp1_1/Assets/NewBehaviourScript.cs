using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // StartCoroutine("TestCor");
        StartCoroutine(TestCor(0));
    }

    //void catTalk()
    //{
    //    //����̰� ������ �Ѵ�.
    //    //������ ������
    //    // cattalk = true;
    //    StartCoroutine(CatTalkCor());  
    //}

    //int count = 0;
    //private void Update()
    //{
    //    if(catTalkv== true){
    //        �÷��̾� �����Ѵ�
    //    }
    //}

    //IEnumerator CatTalkCor()
    //{
    //    while (true)
    //    {
    //        �÷��̾ �����Ѵ�.
    //        yield return null;
    //    }
    //}

    // �ڷ�ƾ ���
    // 1. �̺�Ʈ �ð��� ������ �� ����.
    // 2. ������Ʈ �Լ� ��ü�Ҽ� ����.
    IEnumerator TestCor(int _num)
    {
        yield return new WaitForSeconds(1f);
        Debug.Log("�׽�Ʈ ����");
        yield return StartCoroutine(Test2Cor()); // 1�� �ڿ�
        Debug.Log("����");
    }

    IEnumerator Test2Cor()
    {
        Debug.Log("�׽�Ʈ �ڷ�ƾ 2 ����");
        yield return new WaitForSeconds(1f);
        Debug.Log("�׽�Ʈ �ڷ�ƾ 2 ��");
        yield return new WaitForSeconds(1f);
    }
}
