[Serialize Field]
private GameObject _playerShield;

public void ActivateShield()
{
_playerShield.SetActive(true);
}


private void OnTriggerEnter2D(Collider 2D other) 
{
	if (other.CompareTag("Player"))
	{
		Player player = other.gameObject.GetComponent<Player>();
		if (player != null)
		{

			switch(powerupID)
			{
			case 1;
				player.ActivateShield();
			default;
				Debug.Log("Invalid Powerup");
			}
		}
		Destroy(gameObject);
	}
}


private void OnTriggerEnter2D(Collider 2D other) 
{
	if (other.CompareTag("Player"))
	{
		Destroy(other.gameObject);
		this.gameObject.SetActive(false);
	}
}
