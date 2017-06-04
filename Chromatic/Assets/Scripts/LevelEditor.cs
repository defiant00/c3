using UnityEngine;

public class LevelEditor : MonoBehaviour
{
	GameObject tile;

	void Start()
	{
		Factory.Tile("gwgw_g", 0, 0);
		tile = Factory.Tile("gwgw_w", 1, 1);
	}

	void Update()
	{
		Destroy(tile, 2);
	}
}
