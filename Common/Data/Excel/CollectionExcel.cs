namespace KianaBH.Data.Excel;

[ResourceEntity("Collection.json")]
public class CollectionExcel : ExcelResource
{
    public int ID { get; set; }

    public override int GetId()
    {
        return ID;
    }

    public override void Loaded()
    {
      GameData.CollectionData.Add(ID, this); 
    }
}