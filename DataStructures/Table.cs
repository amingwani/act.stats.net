using System.Collections.Generic;

namespace DataStructures;
public class Table
{
    public string Name { get; set; }
    public HashSet<ColumnBase> Columns { get; set; }
}
