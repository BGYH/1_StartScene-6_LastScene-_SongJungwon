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
    //    //고양이가 질문을 한다.
    //    //질문이 끝나면
    //    // cattalk = true;
    //    StartCoroutine(CatTalkCor());  
    //}

    //int count = 0;
    //private void Update()
    //{
    //    if(catTalkv== true){
    //        플레이어 말을한다
    //    }
    //}

    //IEnumerator CatTalkCor()
    //{
    //    while (true)
    //    {
    //        플레이어가 말을한다.
    //        yield return null;
    //    }
    //}

    // 코루틴 기능
    // 1. 이벤트 시간을 제어할 수 있음.
    // 2. 업데이트 함수 대체할수 있음.
    IEnumerator TestCor(int _num)
    {
        yield return new WaitForSeconds(1f);
        Debug.Log("테스트 실행");
        yield return StartCoroutine(Test2Cor()); // 1초 뒤에
        Debug.Log("종료");
    }

    IEnumerator Test2Cor()
    {
        Debug.Log("테스트 코루틴 2 실행");
        yield return new WaitForSeconds(1f);
        Debug.Log("테스트 코루틴 2 끝");
        yield return new WaitForSeconds(1f);
    }
}
