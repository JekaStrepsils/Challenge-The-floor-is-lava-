using UnityEngine;

public class звук_конца : MonoBehaviour
{
    public float yThreshold = 0f; // Пороговое значение по оси Y, ниже которого будет воспроизводиться звук
    public AudioClip soundClip; // Звук для воспроизведения

    void Update()
    {
        // Проверяем, если позиция шарика по оси Y меньше порогового значения
        if (transform.position.y < yThreshold )
        {
            // Если да, воспроизводим звук
            AudioSource.PlayClipAtPoint(soundClip, transform.position);
        }
    }
}
