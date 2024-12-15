using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float rotateSpeed = 0f; // 회전 속도 변수
    public bool isOnePlay = false; // false면 클릭 가능 상태, true면 클릭 불가능
    private bool isRotate = false; // false면 멈춤 상태, true면 회전 상태

    void Start()
    {
        // 필요한 초기화 작업 추가 가능
    }

    void Update()
    {
        // R키를 눌렀을 때, 룰렛이 멈춘 상태에서만 초기화
        if (Input.GetKeyDown(KeyCode.R) && rotateSpeed == 0f && !isRotate)
        {
            ResetRoulette(); // 초기화 메서드 호출
        }

        // 한 번 플레이 가능한 상태에서 처리
        if (!isOnePlay)
        {
            // 멈춘 상태에서 클릭 시 회전 시작
            if (Input.GetMouseButtonDown(0) && !isRotate) // 마우스 왼쪽 버튼 클릭
            {
                rotateSpeed = Random.Range(7f, 15f); // 랜덤 속도 설정
                isRotate = true; // 회전 상태 활성화
            }
            // 회전 중 클릭 시 감속 시작
            else if (Input.GetMouseButtonDown(0) && isRotate)
            {
                isRotate = false; // 회전 상태 비활성화
                isOnePlay = true; // 한 번 플레이 상태 활성화
            }
        }

        // 감속 처리
        if (!isRotate && rotateSpeed > 0.1f)
        {
            rotateSpeed *= 0.995f; // 감속
            if (rotateSpeed <= 0.1f)
            {
                rotateSpeed = 0f; // 멈춤
            }
        }

        // 룰렛 회전
        transform.Rotate(0f, 0f, rotateSpeed);
    }

    // 룰렛 초기화 메서드
    void ResetRoulette()
    {
        rotateSpeed = 0f;   // 회전 속도 초기화
        isOnePlay = false;  // 클릭 가능 상태로 복구
        isRotate = false;   // 회전 상태 초기화
        transform.rotation = Quaternion.identity; // 룰렛 각도 초기화
        Debug.Log("룰렛이 초기화되었습니다.");
    }
}