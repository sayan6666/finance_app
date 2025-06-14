using UnityEngine;
using SQLite4Unity3d;
using System.Linq;
using System.IO;
using UnityEngine.Networking;
using Unity.VisualScripting.Antlr3.Runtime.Collections;

public class DB_Handler : MonoBehaviour
{
    public static bool first_launch = false;

    public static SQLiteConnection connection;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void Establish_Connection()
    {
        if (!File.Exists(Path.Combine(Application.persistentDataPath,"Data.db")))
        {
            WWW reader = new WWW(Path.Combine(Application.streamingAssetsPath,"Data.db"));
            
            while (!reader.isDone) { }
            
            File.WriteAllBytes(Path.Combine(Application.persistentDataPath,"Data.db"), reader.bytes);
            //File.Create(Path.Combine(Application.persistentDataPath, "Data.db"));
            //first_launch = true;
        }
        connection = new SQLiteConnection(Application.persistentDataPath+"/Data.db"/*Application.streamingAssetsPath+"/Data.db"*/);
    }

    public static void Create_DataBase()
    {
        connection.CreateTable<StockFields>();
        connection.CreateTable<PlayerFields>();
    }

    public static void Insert_Stock(StockFields stock)
    {
        connection.Insert(stock);
    }

    public static void Update_Stock(StockFields stock)
    {
        connection.Update(stock);
    }

    public static void Update_Player(PlayerFields player)
    {
        connection.Update(player);
    }

    public static StockFields Retrieve_Stock(int id)
    {
        return connection.Table<StockFields>().Where(i => i.id == id).FirstOrDefault();
    }

    public static PlayerFields Retrieve_Player()
    {
        return connection.Table<PlayerFields>().FirstOrDefault();
    }
}
