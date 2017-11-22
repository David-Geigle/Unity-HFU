using UnityEngine;
using UnityEngine.UI;

public class PfeilCooldown : MonoBehaviour
{

	public static bool isOnCooldown; //globale variable für Cooldown(CD)

	public Image contend;  //referenz zur Cooldown anzeige

	
	public static float Cooldown = 7F;
	public static float timeRemaining = 0F;

	public float cooldown; //Cooldown, den man im inspector einstellen kann

	void Start()
	{
		Cooldown = cooldown;
	}


	void Update()
	{
		if (isOnCooldown)
		{
			contend.color = new Color(255, 255, 255);
			timeRemaining -= Time.deltaTime; //jedes Frame wird eine FPS abhängige zeit abgezogen
			if (timeRemaining > 0)
			{

			}
			else
			{
				isOnCooldown = false;
				timeRemaining = 0f;
			}
		}
		contend.fillAmount = 1 - (timeRemaining / Cooldown); //die Anzeige wird gefüllt
		if (!isOnCooldown)
			contend.color = Color.green;//wen die Fägigkeit aktivierbar ist wird die anzeige Grün
	}



}
