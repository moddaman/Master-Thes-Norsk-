public class JSONParser
{
 public SymbolList GetSymbolsFromJSON(string filepath)
 {
    string json; 
    using (FileStream fileStream = new FileStream(filepath, FileMode.Open))
    {
        using (StreamReader streamReader = new StreamReader(fileStream))
        {
            json = streamReader.ReadToEnd();
         }
    }
    SymbolList symbolList = JsonConvert.DeserializeObject<SymbolList>(json);
    return symbolList;
  }
}