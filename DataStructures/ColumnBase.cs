namespace DataStructures;
public class ColumnBase
{
    protected string Name { get; set; }
    protected string Caption { get; set; }
    protected Orientation Orientation { get; set; }
}

public enum Orientation
{
    Horizontal,
    Vertical
}