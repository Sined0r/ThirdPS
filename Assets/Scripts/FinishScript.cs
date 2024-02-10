using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishScript : MonoBehaviour
{
    public int allEnemiesCount;

    [SerializeField] AudioSource endGameSound;
    [SerializeField] GameObject winPanel;

    private void Start()
    {
        winPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void ReduceEnemies()
    {
        allEnemiesCount -= 1;

        if (allEnemiesCount <= 0) Finish();
    }

    private void Finish()
    {
        endGameSound.PlayOneShot(endGameSound.clip);

        Invoke(nameof(Pause), 5f);
    }

    private void Pause()
    {
        Time.timeScale= 0f;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        winPanel.SetActive(true);
    }
}
