var lines = File.ReadAllLines("input.txt");
List<Tile> tiles = new();
for (var i = 0; i < lines.Length; i += 12)
{
    var id = int.Parse(lines[i].Replace(":", "").Split(' ')[1]);
    var activeTile = new Tile { Id = id };
    var start = i + 1;
    var end = i + 10;
    activeTile.Bits.Add(lines[start]);
    activeTile.Bits.Add(lines[end++]);
    activeTile.Bits.Add(string.Join("", lines[start..end].Select(x => x[0])));
    activeTile.Bits.Add(string.Join("", lines[start..end].Select(x => x[9])));
    tiles.Add(activeTile);
}


class Tile
{
    public int Id { get; set; }
    public List<string> Bits { get; set; } = new();
}