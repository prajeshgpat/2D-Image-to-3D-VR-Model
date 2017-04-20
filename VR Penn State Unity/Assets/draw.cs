using UnityEngine;
using System.Collections;
using System.Text;
using System.IO;

public class draw : MonoBehaviour {
	public ParticleSystem particles;
	ParticleSystem.Particle[] dataSet = new ParticleSystem.Particle[];
	public ArrayList fileData = new ArrayList ();
	// Use this for initialization

	void readText(string filePath){
		StreamReader inputStream = new StreamReader (filePath);

		while(!inputStream.EndOfStream)
		{
			string inputLine = inputStream.ReadLine(filePath);
			int comma = 0;
			for(int i = 0; i < inputLine.Length(); i++)
			{
				if (inputLine[i] == " ")
				{
					comma = i;
				}
			}
			fileData.Add(inputLine.Substring(0, comma - 1), inputLine.Substring(comma + 3, inputLine.length () - 1));
		}
		inputStream.Close ();
		print (dataSet);
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
