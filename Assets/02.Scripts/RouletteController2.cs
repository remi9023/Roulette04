using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class RouletteController2 : MonoBehaviour
//{
//    public float initialSpeed = 300f; // 초기 회전 속도
//    public float deceleration = 10f; // 감속 속도
//    public Text liveText;            // 실시간으로 표시되는 텍스트
//    public Text resultText;          // 최종 결과를 표시할 텍스트
//    public string[] sections = { "운수보통", "운수조심", "운수좋음", "운수나쁨", "운수대통", "운수매우나쁨" }; // 섹션 텍스트

//    private float currentSpeed;      // 현재 속도
//    private bool isSpinning = false; // 룰렛 회전 여부
//    private bool isDecelerating = false; // 감속 여부
//    private int sectionCount;        // 섹션 수

//    void Start()
//    {
//        sectionCount = sections.Length; // 섹션 수 초기화
//        liveText.text = "";             // 실시간 텍스트 초기화
//        resultText.text = "";           // 결과 텍스트 초기화
//    }

//    void Update()
//    {
//        // 마우스 클릭 감지
//        if (Input.GetMouseButtonDown(0)) // 왼쪽 마우스 클릭
//        {
//            HandleClick();
//        }

//        // 룰렛 회전 로직
//        if (isSpinning)
//        {
//            transform.Rotate(0, 0, currentSpeed * Time.deltaTime);

//            // 실시간 구역 업데이트
//            UpdateLiveText();

//            // 감속 처리
//            if (isDecelerating)
//            {
//                if (currentSpeed > 0)
//                {
//                    currentSpeed -= deceleration * Time.deltaTime;
//                }
//                else
//                {
//                    currentSpeed = 0;
//                    isSpinning = false;
//                    isDecelerating = false;
//                    ShowResult(); // 최종 결과 표시
//                    Debug.Log("룰렛이 멈췄습니다!");
//                }
//            }
//        }
//    }

//    void HandleClick()
//    {
//        if (!isSpinning)
//        {
//            // 룰렛을 일정 속도로 시작
//            currentSpeed = initialSpeed;
//            isSpinning = true;
//            isDecelerating = false; // 감속 상태 초기화
//            resultText.text = "";   // 이전 결과 초기화
//        }
//        else if (!isDecelerating)
//        {
//            // 감속을 시작
//            isDecelerating = true;
//        }
//    }

//    void UpdateLiveText()
//    {
//        // 현재 룰렛의 Z축 회전 각도
//        float currentAngle = transform.eulerAngles.z;

//        // 360도를 기준으로 회전 각도를 섹션에 매핑
//        float sectionAngle = 360f / sectionCount; // 섹션 하나의 각도
//        int selectedSection = (int)((360f - currentAngle + (sectionAngle / 2)) % 360 / sectionAngle);

//        // 실시간 텍스트 업데이트
//        liveText.text = $"현재 운수: {sections[selectedSection]}";
//    }

//    void ShowResult()
//    {
//        // 현재 룰렛의 Z축 회전 각도
//        float currentAngle = transform.eulerAngles.z;

//        // 360도를 기준으로 회전 각도를 섹션에 매핑
//        float sectionAngle = 360f / sectionCount; // 섹션 하나의 각도
//        int selectedSection = (int)((360f - currentAngle + (sectionAngle / 2)) % 360 / sectionAngle);

//        // 결과 텍스트 업데이트
//        resultText.text = $"최종 결과: {sections[selectedSection]}";
//    }
//}
