{$reference ABCNET.dll}
uses ABCNET.Utils;
uses ABCNET.Extensions;
begin
  var t := BaseU.ReadInteger('T:');
  Arr.Rand(BaseU.ReadInteger('N:'), -56, 47).Println()
      .Where((x, i) -> (i mod 2 = 0) and (x > t)).Aggregate((a, b) -> a * b).Println();
  BaseU.ReadChar();
end.