{$reference ABCNET.dll}
uses ABCNET.Utils;
uses ABCNET.Extensions;
uses System;

function Min(self: array [,] of integer): integer; extensionmethod;
begin
  if self = nil then
    raise new ArgumentNullException('self');

  result := integer.MaxValue;
  var rowsCount := self.GetLength(0);
  var colsCount := self.GetLength(1);
  for var i := 0 to rowsCount - 1 do
    for var j := 0 to colsCount - 1 do
      if result > self[i, j] then
        result := self[i, j];
end;

begin
  Matr.Rand(Base.ReadInteger('N:'), Base.ReadInteger('M:'), -30, 45).Print().Min().Println();
end.