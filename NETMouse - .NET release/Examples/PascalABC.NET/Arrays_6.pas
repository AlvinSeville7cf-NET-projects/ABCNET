{$reference ABCNET.dll}
uses ABCNET.Utils;
uses ABCNET.Extensions;
begin
  Arr.Rand(Base.ReadInteger('N:'), -19, 26).Println()
    .Where((x, i) -> i mod 2 <> 0).Aggregate((a, b) -> a * b).Println();
  Base.ReadChar();
end.