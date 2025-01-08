using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // Thêm thư viện TextMeshPro

public class GameUI : MonoBehaviour
{
    // TextMeshPro để hiển thị thời gian
    public TextMeshProUGUI timerText;

    // Biến để giữ thời gian từ GameManager
    private GameManager gameManager;

    // Khởi tạo gameManager
    private void Start()
    {
        gameManager = GameManager.Instance;

        if (gameManager == null)
        {
            Debug.LogError("GameManager not found! Make sure GameManager is initialized.");
        }
    }

    private void Update()
    {
        // Kiểm tra nếu gameManager không null và thời gian đang được tính
        if (gameManager != null && gameManager.IsTiming())
        {
            // Cập nhật thời gian lên UI
            UpdateTimerDisplay(gameManager.GetTimer());
        }
    }

    // Cập nhật giá trị thời gian trên TextMeshPro
    private void UpdateTimerDisplay(float time)
    {
        // Chuyển thời gian sang phút:giây và hiển thị
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
