using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float rotateSpeed = 0f; // ȸ�� �ӵ� ����
    public bool isOnePlay = false; // false�� Ŭ�� ���� ����, true�� Ŭ�� �Ұ���
    private bool isRotate = false; // false�� ���� ����, true�� ȸ�� ����

    void Start()
    {
        // �ʿ��� �ʱ�ȭ �۾� �߰� ����
    }

    void Update()
    {
        // RŰ�� ������ ��, �귿�� ���� ���¿����� �ʱ�ȭ
        if (Input.GetKeyDown(KeyCode.R) && rotateSpeed == 0f && !isRotate)
        {
            ResetRoulette(); // �ʱ�ȭ �޼��� ȣ��
        }

        // �� �� �÷��� ������ ���¿��� ó��
        if (!isOnePlay)
        {
            // ���� ���¿��� Ŭ�� �� ȸ�� ����
            if (Input.GetMouseButtonDown(0) && !isRotate) // ���콺 ���� ��ư Ŭ��
            {
                rotateSpeed = Random.Range(7f, 15f); // ���� �ӵ� ����
                isRotate = true; // ȸ�� ���� Ȱ��ȭ
            }
            // ȸ�� �� Ŭ�� �� ���� ����
            else if (Input.GetMouseButtonDown(0) && isRotate)
            {
                isRotate = false; // ȸ�� ���� ��Ȱ��ȭ
                isOnePlay = true; // �� �� �÷��� ���� Ȱ��ȭ
            }
        }

        // ���� ó��
        if (!isRotate && rotateSpeed > 0.1f)
        {
            rotateSpeed *= 0.995f; // ����
            if (rotateSpeed <= 0.1f)
            {
                rotateSpeed = 0f; // ����
            }
        }

        // �귿 ȸ��
        transform.Rotate(0f, 0f, rotateSpeed);
    }

    // �귿 �ʱ�ȭ �޼���
    void ResetRoulette()
    {
        rotateSpeed = 0f;   // ȸ�� �ӵ� �ʱ�ȭ
        isOnePlay = false;  // Ŭ�� ���� ���·� ����
        isRotate = false;   // ȸ�� ���� �ʱ�ȭ
        transform.rotation = Quaternion.identity; // �귿 ���� �ʱ�ȭ
        Debug.Log("�귿�� �ʱ�ȭ�Ǿ����ϴ�.");
    }
}