﻿using System.Xml;
using UnityEngine;

namespace Joserbala.DialogueSystem
{
	public class DialogueDatabase
	{
		private const string DIALOGUE_FOLDER = "Dialogues";

		/// <summary>
		/// Returns the dialogue <paramref name="dialogueName"/> stored in the StreamingAssets/<see cref="DIALOGUE_FOLDER"/> folder.
		/// </summary>
		/// <param name="dialogueName">File to load (with extension!).</param>
		/// <returns>The XmlDocument stored at <paramref name="dialogueName"/>.</returns>
		public static XmlDocument Load(string dialogueName)
		{
			var xmlDoc = new XmlDocument();
			xmlDoc.Load(System.IO.Path.Combine(Application.streamingAssetsPath, DIALOGUE_FOLDER, dialogueName));

			return xmlDoc;
		}
	}
}
