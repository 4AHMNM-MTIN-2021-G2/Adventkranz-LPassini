using UnityEngine;
using UnityEngine.UI;

public class CountDays : MonoBehaviour
{



    public Text DaysGui;
    private System.DateTime christmasDay, currentDay;

    System.DateTime firstAdvent;
    System.DateTime secondAdvent;
    System.DateTime thirdAdvent;
    System.DateTime fourthAdvent;
    // System.DateTime christmasDay;
    private int days = 0;
    private System.DateTime currTestDay;

    // Start is called before the first frame update
    void Start()
    {
        firstAdvent = new System.DateTime(2020, 11, 29);
        secondAdvent = new System.DateTime(2020, 12, 06);
        thirdAdvent = new System.DateTime(2020, 12, 13);
        fourthAdvent = new System.DateTime(2020, 12, 20);
        christmasDay = new System.DateTime(2020, 12, 24);

        currentDay = System.DateTime.Today;
        TotalDaysToChristmas();
    }
    private void TotalDaysToChristmas()
    {
        while (currentDay.CompareTo(christmasDay) < 0)
        {
            currentDay = currentDay.AddDays(1);
            days++;
        }
       DaysGui.text = days.ToString();
    }
}
