using UnityEngine;


public class TypeWriter
{
	string text;

	int textPointer;

	public TypeWriter(string pText)
	{
		text = pText;
		textPointer = 0;
	}

	public string Update()
	{
		return text.Substring(0, ++textPointer);
	}

	public bool isComplete
	{
		get
		{
			return textPointer > text.Length - 1;
		}
	}


}






