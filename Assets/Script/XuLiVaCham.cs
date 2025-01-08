using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class XuLiVaCham : MonoBehaviour
{
    public GameObject endLineUI;  // Image chứa các nút
    public UnityEngine.UI.Button resumeButton;  // Nút Resume
    public UnityEngine.UI.Button garageButton;  // Nút Garage
    public UnityEngine.UI.Button mainMenuButton;  // Nút Main Menu

    private void Start()
    {
        // Kiểm tra và gán sự kiện cho các nút
        if (resumeButton != null)
            resumeButton.onClick.AddListener(ResumeGame);

        if (garageButton != null)
            garageButton.onClick.AddListener(LoadGarageScene);

        if (mainMenuButton != null)
            mainMenuButton.onClick.AddListener(LoadSampleScene);

        // Đảm bảo UI ẩn khi bắt đầu
        if (endLineUI != null)
            endLineUI.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Start"))
        {
            GameManager.Instance.QuaStart();  // Bắt đầu tính giờ
        }

        if (other.gameObject.CompareTag("End"))
        {
            GameManager.Instance.EndTime();  // Kết thúc tính giờ
            if (endLineUI != null)
            {
                endLineUI.SetActive(true);  // Hiển thị UI khi chạm vạch đích
                Debug.Log("End line reached! UI activated.");
            }
        }
    }

    public void ResumeGame()
    {
        if (endLineUI != null)
        {
            endLineUI.SetActive(false);  // Ẩn UI
        }
        GameManager.Instance.QuaStart();  // Tiếp tục tính giờ nếu cần
        Debug.Log("Game resumed.");
    }

    public void LoadGarageScene()
    {
        SceneManager.LoadScene("GarageScene");
        Debug.Log("GarageScene loaded.");
    }

    public void LoadSampleScene()
    {
        SceneManager.LoadScene("SampleScene");
        Debug.Log("SampleScene loaded.");
    }
}
