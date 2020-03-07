{$reference ABCNET.dll}
uses ABCNET.Utils;
uses ABCNET.Extensions;
begin
  Arr.Rand(Base.ReadInt32('N:'), -19, 26).Println()
    .Where((x, i) -> i mod 2 <> 0).Prod().Println();
  Base.ReadChar();
end.