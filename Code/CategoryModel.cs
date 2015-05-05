public class Category
{
   
    public string Name { get; set; }

    public ObservableCollection<ObservableCollection<Symbol>> CategoryPages { get; set; }
}