using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talk : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Проверяем нажатие правой кнопки мыши
        if (Input.GetMouseButtonDown(1))
        {
            // Получаем позицию клика
            Vector3 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // Проверяем, если клик произошел на данном объекте
            if (GetComponent<Collider2D>().OverlapPoint(clickPosition))
            {
                // Запускаем анимацию разговора
                animator.SetBool("talk", true);
                // Ждем 3 секунды и отключаем анимацию разговора
                StartCoroutine(ResetTalk());
            }
        }
    }

    IEnumerator ResetTalk()
    {
        yield return new WaitForSeconds(3);
        animator.SetBool("talk", false);
    }
}
