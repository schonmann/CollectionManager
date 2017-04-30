using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

[JsonConverter(typeof(StringEnumConverter))]
public enum ItemType : int
{
    Book = 0,
    CD = 1,
    DVD = 2
}
[JsonConverter(typeof(StringEnumConverter))]
public enum ItemTypePt : int
{
    Livro = 0,
    CD = 1,
    DVD = 2
}