using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// up to 16:00 in video

public class MyGrid {

    private int width;
    private int height;
	private float cellSize;
    private int[,] gridArray;
	private TextMesh[,] debugTextArray;

    public MyGrid(int width, int height, float cellSize) {
        this.width = width;
        this.height = height;
		this.cellSize = cellSize;

        gridArray = new int[width, height];
		debugTextArray = new TextMesh[width, height];

        for (int i = 0; i < gridArray.GetLength(0); i++) {
            for (int j = 0; j < gridArray.GetLength(1); j++) {
                debugTextArray [x,y] = CreateWorldText(gridArray[i, j].ToString(), null, GetWorldPosition(i, j), 20, Color.white, TextAnchor.MiddleCenter;
				
				/* Uncomment this to test debug -- adds edges of grid (click Gizmos to see the lines)
					Debug.DrawLine(GetWorldPosition(i, j), GetWorldPosition(i, j+1), Color.white, 100f);
					Debug.DrawLine(GetWorldPosition(i, j), GetWorldPosition(i +1, j), Color.white, 100f);
				*/
				
            }
        }
		/* Continuing from last debug
		Debug.DrawLine(GetWorldPosition(0, height), GetWorldPosition(i, j+1), Color.white, 100f);
		Debug.DrawLine(GetWorldPosition(width, 0), GetWorldPosition(i +1, j), Color.white, 100f);
	*/
   }
	
	private Vector3 GetWorldPosition(int i, int j) {
		return new Vector3(i, j) * cellSize;
	}
	
	public void SetValue(int x, int y, int value) {
		if (x >= 0 && y >= 0 && x < width && y < height) {
			gridArray[x, y] = value;
			debugextArray[x, y].text = gridArray[x, y].ToString();
		}
	}
	
	private void GetXY(Vector3 worldPosition, out int x, out int y) {
		x = Mathf.FloorToInt(worldPosition.x / cellSize);
		y = Mathf.FloorToInt(worldPosition.y / cellSize);
	}
	
	public void SetValue(Vector3 worldPosition, int value) {
		int x, y;
		GetXY(worldPosition, out x, out y);
		SetValue(x, y, value);
	}
	
	public static TextMesh CreateWorldText(string text, Transform parent = null, Vector3 localPosition = default(Vector3), int fontSize = 40, Color? color = null, TextAnchor textAnchor = TextAnchor.UpperLeft, TextAlignment textAlignment = TextAlignment.Left, int sortingOrder = 5000)
	{
		if (color == null) color = Color.white;
		return CreateWorldText(parent, text, localPosition, fontSize, (Color)color, textAnchor, textAlignment, sortingOrder);
	}
	
	public static TextMesh CreateWorldText(Transform parent, string text, Vector3 localPosition, int fontSize, Color color, TextAnchor textAnchor, sortingOrder /* sorting order here */);
	{
		GameObject gameObject = new GameObject("World_Text", typeof(TextMesh));
		Transform transform = gameObject.transform;
		transform.SetParent(parent, false);
		transform.localPosition = localPosition;
		TextMesh textMesh = gameObject.GetComponent<TextMesh>();
		textMesh.anchor = textAnchor;
		textMesh.alignment = textAlignment;
		textMesh.text = text;
		textMesh.fontSize = fontSize;
		textMesh.color = color;
		textMesh.GetComponent<MeshRenderer>().sortingOrder = sortingOrder;
		return textMesh;
	}
}
