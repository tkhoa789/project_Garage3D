using UnityEngine;
using UnityEngine.SceneManagement;

public class EngineSelector : MonoBehaviour
{
    public void SelectV6()
    {
        SetEngineProperties(50f, 100f, 30f);  // Thiết lập thông số cho V6
    }

    public void SelectV8()
    {
        SetEngineProperties(100f, 200f, 70f);  // Thiết lập thông số cho V8
    }

    public void SelectV10()
    {
        SetEngineProperties(200f, 200f, 100f);  // Thiết lập thông số cho V10
    }

    public void SelectV12()
    {
        SetEngineProperties(200f, 100f, 150f);  // Thiết lập thông số cho V12
    }

    private void SetEngineProperties(float tocDoXe, float lucReXe, float LucPhanh)
    {
        // Lưu trữ thông số động cơ vào PlayerPrefs
        PlayerPrefs.SetFloat("TocDoXe", tocDoXe);
        PlayerPrefs.SetFloat("LucReXe", lucReXe);
        PlayerPrefs.SetFloat("LucPhanh", LucPhanh);

        // Chuyển cảnh sang SampleScene
        SceneManager.LoadScene("SampleScene");
    }
}
