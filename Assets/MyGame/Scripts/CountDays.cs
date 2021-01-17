using UnityEngine;
using UnityEngine.UI;
using System;

public class CountDays : MonoBehaviour
{
    public Text daysGui;

    DateTime christmasDay;
    DateTime firstAdvent;
    DateTime secondAdvent;
    DateTime thirdAdvent;
    DateTime fourthAdvent;
    DateTime currentDay;
    private int days = 0;

    // Start is called before the first frame update
    void Start()
    {

        firstAdvent = new DateTime(2020, 11, 29);
        secondAdvent = new DateTime(2020, 12, 06);
        thirdAdvent = new DateTime(2020, 12, 13);
        fourthAdvent = new DateTime(2020, 12, 20);
        christmasDay = new DateTime(2020, 12, 24);
        currentDay = DateTime.Today;

        daysGui.text = TotalDaysToChristmasV4().ToString();
    }

    private void TotalDaysToChristmasV1()
    {
        while (currentDay.CompareTo(christmasDay) < 0)
        {
            currentDay = currentDay.AddDays(1);
            days++;
        }
        daysGui.text = days.ToString();
    }

    private void TotalDaysToChristmasV2()
    {
        int myDays = 0;

        while (currentDay.CompareTo(christmasDay) < 0)
        {
            currentDay = currentDay.AddDays(1);
            myDays++;
        }
        daysGui.text = myDays.ToString();
    }

    private void TotalDaysToChristmasV3()
    {
        double myDays = christmasDay.Subtract(currentDay).TotalDays;
        daysGui.text = myDays.ToString();
    }

    private double TotalDaysToChristmasV4()
    {
        return christmasDay.Subtract(currentDay).TotalDays;
    }

    void TestLocalVars()
    {
        Debug.Log("Test instanz; " + days);
        //Debug.Log("Test local; " + myDays);
    }
}