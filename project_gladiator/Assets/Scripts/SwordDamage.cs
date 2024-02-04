using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwordDamage : MonoBehaviour
{

    public GameObject enemyHealth;
    private Image enemyHealthImage;
    public CombatScript combatScript;
    public bool attacking;
    GameObject playerObject;


    private void Awake()
    {
        enemyHealth = GameObject.Find("EnemyHealth");
        enemyHealthImage = enemyHealth.GetComponent<Image>();
        playerObject = GameObject.Find("Player(Clone)");
        combatScript = playerObject.GetComponent<CombatScript>();

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            enemyHealthImage.fillAmount -= 0.1f;
            Debug.Log("HIT");
        }
    }
}
