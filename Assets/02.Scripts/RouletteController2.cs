using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class RouletteController2 : MonoBehaviour
//{
//    public float initialSpeed = 300f; // �ʱ� ȸ�� �ӵ�
//    public float deceleration = 10f; // ���� �ӵ�
//    public Text liveText;            // �ǽð����� ǥ�õǴ� �ؽ�Ʈ
//    public Text resultText;          // ���� ����� ǥ���� �ؽ�Ʈ
//    public string[] sections = { "�������", "�������", "�������", "�������", "�������", "����ſ쳪��" }; // ���� �ؽ�Ʈ

//    private float currentSpeed;      // ���� �ӵ�
//    private bool isSpinning = false; // �귿 ȸ�� ����
//    private bool isDecelerating = false; // ���� ����
//    private int sectionCount;        // ���� ��

//    void Start()
//    {
//        sectionCount = sections.Length; // ���� �� �ʱ�ȭ
//        liveText.text = "";             // �ǽð� �ؽ�Ʈ �ʱ�ȭ
//        resultText.text = "";           // ��� �ؽ�Ʈ �ʱ�ȭ
//    }

//    void Update()
//    {
//        // ���콺 Ŭ�� ����
//        if (Input.GetMouseButtonDown(0)) // ���� ���콺 Ŭ��
//        {
//            HandleClick();
//        }

//        // �귿 ȸ�� ����
//        if (isSpinning)
//        {
//            transform.Rotate(0, 0, currentSpeed * Time.deltaTime);

//            // �ǽð� ���� ������Ʈ
//            UpdateLiveText();

//            // ���� ó��
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
//                    ShowResult(); // ���� ��� ǥ��
//                    Debug.Log("�귿�� ������ϴ�!");
//                }
//            }
//        }
//    }

//    void HandleClick()
//    {
//        if (!isSpinning)
//        {
//            // �귿�� ���� �ӵ��� ����
//            currentSpeed = initialSpeed;
//            isSpinning = true;
//            isDecelerating = false; // ���� ���� �ʱ�ȭ
//            resultText.text = "";   // ���� ��� �ʱ�ȭ
//        }
//        else if (!isDecelerating)
//        {
//            // ������ ����
//            isDecelerating = true;
//        }
//    }

//    void UpdateLiveText()
//    {
//        // ���� �귿�� Z�� ȸ�� ����
//        float currentAngle = transform.eulerAngles.z;

//        // 360���� �������� ȸ�� ������ ���ǿ� ����
//        float sectionAngle = 360f / sectionCount; // ���� �ϳ��� ����
//        int selectedSection = (int)((360f - currentAngle + (sectionAngle / 2)) % 360 / sectionAngle);

//        // �ǽð� �ؽ�Ʈ ������Ʈ
//        liveText.text = $"���� ���: {sections[selectedSection]}";
//    }

//    void ShowResult()
//    {
//        // ���� �귿�� Z�� ȸ�� ����
//        float currentAngle = transform.eulerAngles.z;

//        // 360���� �������� ȸ�� ������ ���ǿ� ����
//        float sectionAngle = 360f / sectionCount; // ���� �ϳ��� ����
//        int selectedSection = (int)((360f - currentAngle + (sectionAngle / 2)) % 360 / sectionAngle);

//        // ��� �ؽ�Ʈ ������Ʈ
//        resultText.text = $"���� ���: {sections[selectedSection]}";
//    }
//}
