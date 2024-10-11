using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);

    void Update()
    {
        
        //if(Input.anyKeyDown)
        //    Debug.Log("플레이어가 아무 키를 눌렀습니다.");

        //if (Input.anyKey)
        //    Debug.Log("플레이어가 아무 키를 누르고 있습니다.");

        
        //1. 키보드 입력
        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("아이템을 구입하였습니다.");

        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("왼쪽으로 이동 중..");

        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("오른쪽으로 이동 완료.");

        
        //2. 마우스 입력
        if (Input.GetMouseButtonDown(1)) //0:좌클릭, 1:우클릭
            Debug.Log("미사일 발사!");

        if (Input.GetMouseButton(0))
            Debug.Log("미사일 모으는 중...");

        if (Input.GetMouseButtonUp(0))
            Debug.Log("슈퍼 미사일 발사!!");


        //3. Input Manager를 이용한 입력
        if (Input.GetButtonDown("Jump")) //대소문자 구분해서 작성한다. 
            Debug.Log("점프!");

        if (Input.GetButton("Jump"))
            Debug.Log("점프 모으는 중...");

        if (Input.GetButtonUp("Jump"))
            Debug.Log("슈퍼 점프!!!!!!!!!!");

        if (Input.GetButtonDown("Fire1"))
            Debug.Log("점프!");

        if (Input.GetButton("Fire1"))
            Debug.Log("점프 모으는 중...");

        if (Input.GetButtonUp("Fire1"))
            Debug.Log("슈퍼 점프!!!!!!!!!!");


        if (Input.GetButtonDown("Fire2"))
            Debug.Log("필살기!!!!!!!!!!");

        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("횡 이동 중..."+ Input.GetAxisRaw("Horizontal")); //Input.GetAxis 가중치(실수형)를 가진다., Input.GetAxisRaw는 1,-1의 값만 가진다.  

        }

        if (Input.GetButton("Vertical"))
            Debug.Log("종 이동 중..." + Input.GetAxisRaw("Vertical"));
        

        //4. 오브젝트 이동
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0); //Vector3는 3차원 벡터라는 의미이다. 현재 위치에서 이동한다. 
        transform.Translate(vec);


        //1) MoveTowards
        
        transform.position = Vector3.MoveTowards(transform.position, target, 1f);

        //2) SmoothDamp
        Vector3 velo = Vector3.zero;
        transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 1f);
        
         

        //3) Lerp (선형 보간)
        transform.position = Vector3.Lerp(transform.position, target, 0.05f);
       

        //4) SLerp (구면 선형 보간)
        transform.position = Vector3.Slerp(transform.position, target, 0.005f);

        

    }

    void Start()
    {
       
    }
}
