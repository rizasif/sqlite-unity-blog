using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;
using System.IO;

public class SqliteTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string connection = "URI=file:" + Application.persistentDataPath + "/" + "My_Database";
		IDbConnection dbcon = new SqliteConnection(connection);
		dbcon.Open();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
