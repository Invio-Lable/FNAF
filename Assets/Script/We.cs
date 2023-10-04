using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class We : MonoBehaviour
{
    public float gifDuration = 5.0f; // Тривалість GIF в секундах
    public string nextSceneName; // Ім'я наступної сцени, на яку потрібно перейти

    private float timer = 0.0f;
    private bool isGifPlaying = true;

    // Update is called once per frame
    void Update()
    {
        if (isGifPlaying)
        {
            timer += Time.deltaTime;
            if (timer >= gifDuration)
            {
                isGifPlaying = false;
                // Перехід на іншу сцену
                SceneManager.LoadScene(nextSceneName);
            }
        }
    }
}
