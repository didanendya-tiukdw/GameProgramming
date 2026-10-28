using UnityEngine;
using TMPro;

public class GameState : MonoBehaviour
{
    public TMP_Text cellText;
    public GameObject winPanel;

    private int cells = 0;

    void Start()
    {
        winPanel.SetActive(false);
        Refresh();
    }

    public void AddCell()
    {
        cells++;
        Refresh();
    }

    void Refresh()
    {
        cellText.SetText($"Cells: {cells}/3");
    }

    public void TryWin()
    {
        if (cells >= 3)
            winPanel.SetActive(true);
    }
}