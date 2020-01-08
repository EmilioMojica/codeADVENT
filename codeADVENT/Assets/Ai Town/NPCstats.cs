using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCstats : MonoBehaviour
{
    [Header("EntityID")]
    [SerializeField] public int ID;

    [Header("Moral Compass")]
    public bool Good;
    public bool Neutral1;
    public bool Evil;

    [Header("We live in a Society?")]
    public bool Lawful;
    public bool Neutral2;
    public bool Chaos;

    [Header("Sentient?")]
    public bool Fauna;
    public bool Flora;

    [Header("Health")]
    [SerializeField] public float HP;
    [SerializeField] public float maxHP;

    [Header("Mana")]
    [SerializeField] public float MP;
    [SerializeField] public float maxMP;

    [Header("Overall Healthiness")]
    [SerializeField] public float InternalClock;
    [SerializeField] public float Rested;
    [SerializeField] public float Stamina;
    [SerializeField] public float maxStamina;

    [Header("Motabolism")]
    [SerializeField] public float Hunger;
    [SerializeField] public float Full;

    [Header("Satisfaction")]
    [SerializeField] public float Morale;
    [SerializeField] public float maxMorale;

    // Start is called before the first frame update
    void Start()
    {
        ID = Random.Range(0, 1000);

        gameObject.name = "Entity" + ID;
        settingRanges();
    }

    // Update is called once per frame
    void Update()
    {
        checkingStats();
    }

    private void setMaxRejuvination()
    {
        HP = maxHP;
        MP = maxMP;
        Stamina = maxStamina;
        Hunger = Full;
        InternalClock = Rested;
        Morale = maxMorale;
    }

    private void settingRanges()
    {
        maxHP = Random.Range(0, 100);
        HP = Random.Range(0, maxHP);

        maxMP = Random.Range(0, 100);
        MP = Random.Range(0, maxMP);

        maxStamina = Random.Range(0, 100);
        Stamina = Random.Range(0, maxStamina);

        Rested = Random.Range(0, 10000);
        InternalClock = Random.Range(0, Rested);

        Full = Random.Range(0, 100);
        Hunger = Random.Range(0, Full);

        maxMorale = Random.Range(0, 100);
        Morale = Random.Range(0, maxMorale);
    }

    private void checkingStats()
    {
        if (HP == HP * 0.3f)
        {
            Debug.Log("Entity " + ID + " is low on HP!");
        }

        if (MP == MP * 0.3f)
        {
            Debug.Log("Entity " + ID + " is low on MP!");
        }

        if (Stamina == Stamina * 0.3)
        {
            Debug.Log("Entity " + ID + " needs to rest!");
        }

        if (InternalClock == InternalClock * 0.3)
        {
            Debug.Log("Entity " + ID + " is feeling drowsy.");
            Stamina += Stamina - 0.5f;
        }

        if (Hunger == Full * 0.3)
        {
            Debug.Log("Entity " + ID + " is hungry.");
        }
        else if (Hunger == Full)
        {
            Debug.Log("Entity " + ID + " is full.");
        }
        else if (Hunger == 0)
        {
            HP += HP - 1f;
        }

        if (Morale == Morale * 0.3f)
        {
            Debug.Log("Entity " + ID + " is indifferent.");
        }
        else if (Morale == maxMorale)
        {
            Debug.Log("Entity " + ID + " is very happy!");
        }
    }
}
