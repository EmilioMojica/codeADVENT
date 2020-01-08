using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatBars : MonoBehaviour
{
    // https://answers.unity.com/questions/343602/best-way-to-reference-child-from-parents-script.html
    // https://docs.unity3d.com/ScriptReference/Object-name.html

    public Transform Entity;

    [Header("Health")]
    public Transform healthbar;
    public Slider healthFill;
    public float healthBarYOffset = 1f;

    [Header("Mana")]
    public Transform manabar;
    public Slider manaFill;
    public float manaBarYOffset = 1.2f;

    [Header("Stamina")]
    public Transform staminabar;
    public Slider staminaFill;
    public float staminaBarYOffset = 1.4f;

    [Header("Hunger")]
    public Transform hungerbar;
    public Slider hungerFill;
    public float hungerBarYOffset = 1.6f;

    [Header("Morale")]
    public Transform moralebar;
    public Slider moraleFill;
    public float moraleBarYOffset = 1.8f;

    [Header("InternalClock")]
    public Transform internalclockbar;
    public Slider internalclockFill;
    public float internalclockBarYOffset = 2f;

    float amount;

    // Start is called before the first frame update
    void Start()
    {
        Entity = transform.parent;
        SetBars();
    }

    // Update is called once per frame
    void Update()
    {
        ChangeValues();
        PositionBars();
    }

    public void SetBars()
    {
        //HEALTH
        healthbar = GameObject.Find("Health Bar").transform;
        healthbar.name = "Entity" + Entity.GetComponent<NPCstats>().ID + " Healthbar";
        healthFill = GameObject.Find("Health Slider").GetComponent<Slider>();
        healthFill.name = "Entity" + Entity.GetComponent<NPCstats>().ID + " HealthFill";

        //MANA
        manabar = GameObject.Find("Mana Bar").transform;
        manabar.name = "Entity" + Entity.GetComponent<NPCstats>().ID + " Manabar";
        manaFill = GameObject.Find("Mana Slider").GetComponent<Slider>();
        manaFill.name = "Entity" + Entity.GetComponent<NPCstats>().ID + " ManaFill";

        //STAMINA
        staminabar = GameObject.Find("Stamina Bar").transform;
        staminabar.name = "Entity" + Entity.GetComponent<NPCstats>().ID + " Staminabar";
        staminaFill = GameObject.Find("Stamina Slider").GetComponent<Slider>();
        staminaFill.name = "Entity" + Entity.GetComponent<NPCstats>().ID + " StaminaFill";

        //HUNGER
        hungerbar = GameObject.Find("Hunger Bar").transform;
        hungerbar.name = "Entity" + Entity.GetComponent<NPCstats>().ID + " Hungerbar";
        hungerFill = GameObject.Find("Hunger Slider").GetComponent<Slider>();
        hungerFill.name = "Entity" + Entity.GetComponent<NPCstats>().ID + " HungerFill";

        //MORALE
        moralebar = GameObject.Find("Morale Bar").transform;
        moralebar.name = "Entity" + Entity.GetComponent<NPCstats>().ID + " Moralebar";
        moraleFill = GameObject.Find("Morale Slider").GetComponent<Slider>();
        moraleFill.name = "Entity" + Entity.GetComponent<NPCstats>().ID + " MoraleFill";

        //INTERNAL CLOCK
        internalclockbar = GameObject.Find("InternalClock Bar").transform;
        internalclockbar.name = "Entity" + Entity.GetComponent<NPCstats>().ID + " InternalClockbar";
        internalclockFill = GameObject.Find("InternalClock Slider").GetComponent<Slider>();
        internalclockFill.name = "Entity" + Entity.GetComponent<NPCstats>().ID + " InternalClockFill";
    }

    public void ChangeValues()
    {
        //HEALTH
        Entity.GetComponent<NPCstats>().HP += amount;
        Entity.GetComponent<NPCstats>().HP = Mathf.Clamp(Entity.GetComponent<NPCstats>().HP, 0, Entity.GetComponent<NPCstats>().maxHP);

        healthFill.value = Entity.GetComponent<NPCstats>().HP / Entity.GetComponent<NPCstats>().maxHP;

        //MANA
        Entity.GetComponent<NPCstats>().MP += amount;
        Entity.GetComponent<NPCstats>().MP = Mathf.Clamp(Entity.GetComponent<NPCstats>().MP, 0, Entity.GetComponent<NPCstats>().maxMP);

        manaFill.value = Entity.GetComponent<NPCstats>().MP / Entity.GetComponent<NPCstats>().maxMP;

        //STAMINA
        Entity.GetComponent<NPCstats>().Stamina += amount;
        Entity.GetComponent<NPCstats>().Stamina = Mathf.Clamp(Entity.GetComponent<NPCstats>().Stamina, 0, Entity.GetComponent<NPCstats>().maxStamina);

        staminaFill.value = Entity.GetComponent<NPCstats>().Stamina / Entity.GetComponent<NPCstats>().maxStamina;

        //HUNGER
        Entity.GetComponent<NPCstats>().Hunger += amount;
        Entity.GetComponent<NPCstats>().Hunger = Mathf.Clamp(Entity.GetComponent<NPCstats>().Hunger, 0, Entity.GetComponent<NPCstats>().Full);

        hungerFill.value = Entity.GetComponent<NPCstats>().Hunger / Entity.GetComponent<NPCstats>().Full;

        //MORALE
        Entity.GetComponent<NPCstats>().Morale += amount;
        Entity.GetComponent<NPCstats>().Morale = Mathf.Clamp(Entity.GetComponent<NPCstats>().Morale, 0, Entity.GetComponent<NPCstats>().maxMorale);

        moraleFill.value = Entity.GetComponent<NPCstats>().Morale / Entity.GetComponent<NPCstats>().maxMorale;

        //INTERNAL CLOCK
        Entity.GetComponent<NPCstats>().InternalClock += amount;
        Entity.GetComponent<NPCstats>().InternalClock = Mathf.Clamp(Entity.GetComponent<NPCstats>().InternalClock, 0, Entity.GetComponent<NPCstats>().Rested);

        internalclockFill.value = Entity.GetComponent<NPCstats>().InternalClock / Entity.GetComponent<NPCstats>().Rested;
    }

    private void PositionBars()
    {
        healthbar.position = new Vector3(0 + Entity.GetComponent<Transform>().position.x, 0 + Entity.GetComponent<Transform>().position.y + healthBarYOffset, 0 + Entity.GetComponent<Transform>().position.z);
        manabar.position = new Vector3(0 + Entity.GetComponent<Transform>().position.x, 0 + Entity.GetComponent<Transform>().position.y + manaBarYOffset, 0 + Entity.GetComponent<Transform>().position.z);
        staminabar.position = new Vector3(0 + Entity.GetComponent<Transform>().position.x, 0 + Entity.GetComponent<Transform>().position.y + staminaBarYOffset, 0 + Entity.GetComponent<Transform>().position.z);
        hungerbar.position = new Vector3(0 + Entity.GetComponent<Transform>().position.x, 0 + Entity.GetComponent<Transform>().position.y + hungerBarYOffset, 0 + Entity.GetComponent<Transform>().position.z);
        moralebar.position = new Vector3(0 + Entity.GetComponent<Transform>().position.x, 0 + Entity.GetComponent<Transform>().position.y + moraleBarYOffset, 0 + Entity.GetComponent<Transform>().position.z);
        internalclockbar.position = new Vector3(0 + Entity.GetComponent<Transform>().position.x, 0 + Entity.GetComponent<Transform>().position.y + internalclockBarYOffset, 0 + Entity.GetComponent<Transform>().position.z);

        healthbar.rotation = Quaternion.LookRotation(healthbar.position - Camera.main.transform.position);
        manabar.rotation = Quaternion.LookRotation(manabar.position - Camera.main.transform.position);
        staminabar.rotation = Quaternion.LookRotation(staminabar.position - Camera.main.transform.position);
        hungerbar.rotation = Quaternion.LookRotation(hungerbar.position - Camera.main.transform.position);
        moralebar.rotation = Quaternion.LookRotation(moralebar.position - Camera.main.transform.position);
        internalclockbar.rotation = Quaternion.LookRotation(internalclockbar.position - Camera.main.transform.position);
    }
}
