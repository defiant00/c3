using UnityEngine;

public static class Factory
{
	public static GameObject Tile(string name, int x = 0, int y = 0)
	{
		var tile = new GameObject("t_" + x + "_" + y);
		var sr = tile.AddComponent<SpriteRenderer>();
		sr.sprite = Resources.Load<Sprite>("Sprites\\Tiles\\" + name);
		sr.transform.position = new Vector3(x, y);
		return tile;
	}
}
