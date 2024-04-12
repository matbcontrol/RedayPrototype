using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform player; //ссылка на Transform игрока
    public Vector3 offset; //смещение камеры относительно игрока
    public float smoothSpeed = 0.125f; //скорость сглаживания движения

    private void Start()
    {
        //инициализация
        offset = transform.position - player.position;
    }

    private void LateUpdate()
    {
        //последовательность за игроком
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
