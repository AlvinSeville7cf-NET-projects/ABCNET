{$reference ABCNET.dll}
uses ABCNET.Utils;
uses ABCNET.Extensions;
begin
  var t := Base.ReadInt32('T:');
  Arr.Rand(Base.ReadInt32('N:'), -56, 47).Println()
      .Where((x, i) -> (i mod 2 = 0) and (x > t)).Prod().Println();
  Base.ReadChar();
end.