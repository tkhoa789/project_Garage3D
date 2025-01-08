using UnityEngine;
using UnityEngine.UI;  // Để làm việc với UI

public class PauseManager : MonoBehaviour
{
    public Button pauseButton;  // Kéo thả button vào đây trong Inspector
    private bool isPaused = false;

    void Start()
    {
        // Gán sự kiện khi button được nhấn
        pauseButton.onClick.AddListener(TogglePause);
    }

    void Update()
    {
        // Kiểm tra phím P được nhấn (nếu cần)
        if (Input.GetKeyDown(KeyCode.P))
        {
            TogglePause();  // Đổi trạng thái pause
        }
    }

    void TogglePause()
    {
        isPaused = !isPaused;  // Chuyển đổi trạng thái pause
        Time.timeScale = isPaused ? 0 : 1;  // Dừng hoặc tiếp tục game
    }
}
