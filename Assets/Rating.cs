using UnityEngine;
using UnityEngine.UI;

public class RatingSystem : MonoBehaviour
{
    public void RateGame(int rating)
    {
        Debug.Log("Player rated the game: " + rating);
        // Here you can save the rating, show a thank-you message, etc.
    }
}
