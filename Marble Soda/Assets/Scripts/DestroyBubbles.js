
public var scoreup : Score;

function Start()
{

	scoreup = GameObject.Find("ScoreKeeper").GetComponent(Score);
}

function OnMouseOver()
{
	if(Input.GetMouseButtonDown(0))
	{
		Destroy(gameObject);
	 	scoreup.score += 1;
	}
}

	