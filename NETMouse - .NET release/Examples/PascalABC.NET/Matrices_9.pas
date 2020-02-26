{$reference ABCNET.dll}
uses ABCNET.Utils;
uses ABCNET.Extensions;
uses System;

function Sort(self: array [,] of integer): array [,] of integer; extensionmethod;
type
  T = array [,] of integer;
  
begin
  if self = nil then
    raise new ArgumentNullException('self');

  result := T(self.Clone());
  var rowsCount := result.GetLength(0);
  var colsCount := result.GetLength(1);
  for var j := 0 to colsCount - 1 do
    for var k := 0 to rowsCount - 1 do
      for var i := 0 to rowsCount - k - 2 do
        if result[i, j] > result[i + 1, j] then
          Base.Swap(result[i, j], result[i + 1, j]);
end;

begin
  Matr.Rand(Base.ReadInteger('N:'), Base.ReadInteger('M:'), -17, 26).Print().Sort().Print();
  Base.ReadChar();
end.