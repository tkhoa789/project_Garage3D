using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    private float tocDoXe;
    private float lucReXe;
    private float LucPhanh;

    [SerializeField]
    private GameObject hieuUngPhanh;

    private float dauVaoDiChuyen;
    private float dauVaoRe;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Lấy các thông số động cơ đã lưu từ PlayerPrefs
        tocDoXe = PlayerPrefs.GetFloat("TocDoXe", 100f); // Giá trị mặc định
        lucReXe = PlayerPrefs.GetFloat("LucReXe", 100f);
        LucPhanh = PlayerPrefs.GetFloat("LucPhanh", 50f);
    }

    private void FixedUpdate()
    {
        dauVaoDiChuyen = Input.GetAxis("Vertical");
        dauVaoRe = Input.GetAxis("Horizontal");

        DiChuyenXe();
        ReXe();
        if (dauVaoDiChuyen > 0 && Input.GetKey(KeyCode.Space))
        {
            Phanhxe();
        }
    }

    public void DiChuyenXe()
    {
        rb.AddRelativeForce(Vector3.forward * dauVaoDiChuyen * tocDoXe);
        hieuUngPhanh.SetActive(false);
    }

    public void ReXe()
    {
        Quaternion re = Quaternion.Euler(Vector3.up * dauVaoRe * lucReXe * Time.deltaTime);
        rb.MoveRotation(rb.rotation * re);
    }

    public void Phanhxe()
    {
        if (rb.velocity.z != 0)
        {
            rb.AddRelativeForce(-Vector3.forward * LucPhanh);
            hieuUngPhanh.SetActive(true);
        }
    }
}
