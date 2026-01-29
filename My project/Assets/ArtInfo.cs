using UnityEngine;
using TMPro; // Pastikan Anda menggunakan TextMeshPro untuk teks yang tajam

public class ArtInfo : MonoBehaviour
{
    public GameObject infoPanel; // Drag & drop UI Canvas Anda ke sini
    private bool isVisible = false;

    void Start()
    {
        // Sembunyikan panel informasi saat galeri pertama kali dibuka
        if (infoPanel != null)
            infoPanel.SetActive(false);
    }

    // Fungsi ini akan dipanggil saat lukisan diklik
    public void ToggleInfo()
    {
        isVisible = !isVisible;
        infoPanel.SetActive(isVisible);
    }
}