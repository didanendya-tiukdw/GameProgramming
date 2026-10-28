using UnityEngine;

public class PlayerCollect : MonoBehaviour
{
    public GameState gameState;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("EnergyCell"))
        {
            gameState.AddCell();
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Goal"))
        {
            gameState.TryWin();
        }
    }
}
