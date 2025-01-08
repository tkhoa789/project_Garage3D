using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject endLineUI;  // Tham chiếu đến UI chứa các nút

    // Hàm Resume để ẩn Image và tiếp tục game
    public void ResumeGame()
    {
        endLineUI.SetActive(false);  // Ẩn UI
        GameManager.Instance.QuaStart();  // Tiếp tục đếm giờ
    }

    // Hàm chuyển sang GarageScene
    public void LoadGarageScene()
    {
        SceneManager.LoadScene("GarageScene");
    }

    // Hàm chuyển đến SampleScene
    public void LoadSampleScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
