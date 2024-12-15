using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float rotateSpeed = 0f; // ȸ���ӵ� ����
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // ���콺 ���� ������ 
        {
            rotateSpeed = Random.Range(7f,15f);
        }
        if (rotateSpeed > 0.001f)
        {
            rotateSpeed *= 0.995f;
        }
        else
        {
            rotateSpeed = 0;
        }
        transform.Rotate(0f, 0f, rotateSpeed);
        if (Input.GetMouseButtonDown(1))
        {
            rotateSpeed = rotateSpeed * 0.1f;
        }
    }
       
}
