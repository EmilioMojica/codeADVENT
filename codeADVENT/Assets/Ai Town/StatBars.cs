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
    public float healthBarYOffset = 2f;

    [Header("Mana")]
    public Transform manabar;
    public Slider manaFill;
    public float manaBarYOffset = 1.8f;

    [Header("Stamina")]
    public Transform staminabar;
    public Slider staminaFill;
    public float staminaBarYOffset = 1.6f;

    [Header("Hunger")]
    public Transform hungerbar;
    public Slider hungerFill;
    public float hungerBarYOffset = 1.4f;

    [Header("Morale")]
    public Transform moralebar;
    public Slider moraleFill;
    public float moraleBarYOffset = 1.2f;

    [Header("InternalClock")]
    public Transform internalclockbar;
    public Slider internalclockFill;
    public float internalclockBarYOffset = 1f;

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
        healthbar.name = "Entity" + Entity.GetComponent<Stats>().ID + " Healthbar";
        healthFill = GameObject.Find("Health Slider").GetComponent<Slider>();
        healthFill.name = "Entity" + Entity.GetComponent<Stats>().ID + " HealthFill";

        //MANA
        manabar = GameObject.Find("Mana Bar").transform;
        manabar.name = "Entity" + Entity.GetComponent<Stats>().ID + " Manabar";
        manaFill = GameObject.Find("Mana Slider").GetComponent<Slider>();
        manaFill.name = "Entity" + Entity.GetComponent<Stats>().ID + " ManaFill";

        //STAMINA
        staminabar = GameObject.Find("Stamina Bar").transform;
        staminabar.name = "Entity" + Entity.GetComponent<Stats>().ID + " Staminabar";
        staminaFill = GameObject.Find("Stamina Slider").GetComponent<Slider>();
        staminaFill.name = "Entity" + Entity.GetComponent<Stats>().ID + " StaminaFill";

        //HUNGER
        hungerbar = GameObject.Find("Hunger Bar").transform;
        hungerbar.name = "Entity" + Entity.GetComponent<Stats>().ID + " Hungerbar";
        hungerFill = GameObject.Find("Hunger Slider").GetComponent<Slider>();
        hungerFill.name = "Entity" + Entity.GetComponent<Stats>().ID + " HungerFill";

        //MORALE
        moralebar = GameObject.Find("Morale Bar").transform;
        moralebar.name = "Entity" + Entity.GetComponent<Stats>().ID + " Moralebar";
        moraleFill = GameObject.Find("Morale Slider").GetComponent<Slider>();
        moraleFill.name = "Entity" + Entity.GetComponent<Stats>().ID + " MoraleFill";

        //INTERNAL CLOCK
        internalclockbar = GameObject.Find("InternalClock Bar").transform;
        internalclockbar.name = "Entity" + Entity.GetComponent<Stats>().ID + " InternalClockbar";
        internalclockFill = GameObject.Find("InternalClock Slider").GetComponent<Slider>();
        internalclockFill.name = "Entity" + Entity.GetComponent<Stats>().ID + " InternalClockFill";
    }

    public void ChangeValues()
    {
        //HEALTH
        Entity.GetComponent<Stats>().HP += amount;
        Entity.GetComponent<Stats>().HP = Mathf.Clamp(Entity.GetComponent<Stats>().HP, 0, Entity.GetComponent<Stats>().maxHP);

        healthFill.value = Entity.GetComponent<Stats>().HP / Entity.GetComponent<Stats>().maxHP;

        //MANA
        Entity.GetComponent<Stats>().MP += amount;
        Entity.GetComponent<Stats>().MP = Mathf.Clamp(Entity.GetComponent<Stats>().MP, 0, Entity.GetComponent<Stats>().maxMP);

        manaFill.value = Entity.GetComponent<Stats>().MP / Entity.GetComponent<Stats>().maxMP;

        //STAMINA
        Entity.GetComponent<Stats>().Stamina += amount;
        Entity.GetComponent<Stats>().Stamina = Mathf.Clamp(Entity.GetComponent<Stats>().Stamina, 0, Entity.GetComponent<Stats>().maxStamina);

        staminaFill.value = Entity.GetComponent<Stats>().Stamina / Entity.GetComponent<Stats>().maxStamina;

        //HUNGER
        Entity.GetComponent<Stats>().Hunger += amount;
        Entity.GetComponent<Stats>().Hunger = Mathf.Clamp(Entity.GetComponent<Stats>().Hunger, 0, Entity.GetComponent<Stats>().Full);

        hungerFill.value = Entity.GetComponent<Stats>().Hunger / Entity.GetComponent<Stats>().Full;

        //MORALE
        Entity.GetComponent<Stats>().Morale += amount;
        Entity.GetComponent<Stats>().Morale = Mathf.Clamp(Entity.GetComponent<Stats>().Morale, 0, Entity.GetComponent<Stats>().maxMorale);

        moraleFill.value = Entity.GetComponent<Stats>().Morale / Entity.GetComponent<Stats>().maxMorale;

        //INTERNAL CLOCK
        Entity.GetComponent<Stats>().InternalClock += amount;
        Entity.GetComponent<Stats>().InternalClock = Mathf.Clamp(Entity.GetComponent<Stats>().InternalClock, 0, Entity.GetComponent<Stats>().Rested);

        internalclockFill.value = Entity.GetComponent<Stats>().InternalClock / Entity.GetComponent<Stats>().Rested;
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
