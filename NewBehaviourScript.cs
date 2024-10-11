using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);

    void Update()
    {
        
        //if(Input.anyKeyDown)
        //    Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");

        //if (Input.anyKey)
        //    Debug.Log("�÷��̾ �ƹ� Ű�� ������ �ֽ��ϴ�.");

        
        //1. Ű���� �Է�
        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("�������� �����Ͽ����ϴ�.");

        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("�������� �̵� ��..");

        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("���������� �̵� �Ϸ�.");

        
        //2. ���콺 �Է�
        if (Input.GetMouseButtonDown(1)) //0:��Ŭ��, 1:��Ŭ��
            Debug.Log("�̻��� �߻�!");

        if (Input.GetMouseButton(0))
            Debug.Log("�̻��� ������ ��...");

        if (Input.GetMouseButtonUp(0))
            Debug.Log("���� �̻��� �߻�!!");


        //3. Input Manager�� �̿��� �Է�
        if (Input.GetButtonDown("Jump")) //��ҹ��� �����ؼ� �ۼ��Ѵ�. 
            Debug.Log("����!");

        if (Input.GetButton("Jump"))
            Debug.Log("���� ������ ��...");

        if (Input.GetButtonUp("Jump"))
            Debug.Log("���� ����!!!!!!!!!!");

        if (Input.GetButtonDown("Fire1"))
            Debug.Log("����!");

        if (Input.GetButton("Fire1"))
            Debug.Log("���� ������ ��...");

        if (Input.GetButtonUp("Fire1"))
            Debug.Log("���� ����!!!!!!!!!!");


        if (Input.GetButtonDown("Fire2"))
            Debug.Log("�ʻ��!!!!!!!!!!");

        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("Ⱦ �̵� ��..."+ Input.GetAxisRaw("Horizontal")); //Input.GetAxis ����ġ(�Ǽ���)�� ������., Input.GetAxisRaw�� 1,-1�� ���� ������.  

        }

        if (Input.GetButton("Vertical"))
            Debug.Log("�� �̵� ��..." + Input.GetAxisRaw("Vertical"));
        

        //4. ������Ʈ �̵�
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0); //Vector3�� 3���� ���Ͷ�� �ǹ��̴�. ���� ��ġ���� �̵��Ѵ�. 
        transform.Translate(vec);


        //1) MoveTowards
        
        transform.position = Vector3.MoveTowards(transform.position, target, 1f);

        //2) SmoothDamp
        Vector3 velo = Vector3.zero;
        transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 1f);
        
         

        //3) Lerp (���� ����)
        transform.position = Vector3.Lerp(transform.position, target, 0.05f);
       

        //4) SLerp (���� ���� ����)
        transform.position = Vector3.Slerp(transform.position, target, 0.005f);

        

    }

    void Start()
    {
       
    }
}
