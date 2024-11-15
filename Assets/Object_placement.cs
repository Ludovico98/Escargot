using TMPro;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class ListPlacingItems: MonoBehaviour
{
    public UnityEvent OnScoreChnaged;

    public GameObject TopLeft;
    public GameObject BottomLeft;
    public GameObject TopRight;
    public GameObject BottomRight;

    public static int ScoreValue = 0;

    public TMP_Text score;

    public int Hes;
    public int Hers;
    public int Both;

    public int[] ItemType;

    void Awake()
    {
        score = GetComponent<TMP_Text>();
    }

    void Start()
    {
        score.text = Both.ToString();
        ItemType = new int[3];
        ItemType[0] = Both;
        ItemType[1] = Hes;
        ItemType[2] = Hers;
    }


    void Update()
    {
        if (TopLeft != null) { }
        score.text = "Score: " + ScoreValue;
    }

    void Calculation()
    {
        int total = 0;

        foreach (int item in ItemType)
        {
            total += item;
        }

        Debug.Log("Total value of ItemType array: " + total);

        score.text = total.ToString();
    }

    public void AddScore(int amount)
    {
        ScoreValue += amount;
        OnScoreChnaged.Invoke();
    }

    void UpdateScore()
    {

    }

}
