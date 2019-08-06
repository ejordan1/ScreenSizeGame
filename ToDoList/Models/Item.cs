namespace ToDoList.Models
{
  public class Item
  {
    public int ItemId { get; set; }
    public string Description { get; set; }
    public int CategoryId { get; set; }

    public int Width {get; set;}
    public virtual Category Category { get; set; }
  }
}


// figure out where categories controller is being
