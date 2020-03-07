{$reference ABCNET.dll}
uses ABCNET.Utils;
uses ABCNET.Extensions;
uses System;

function Max(self: array [,] of integer): integer; extensionmethod;
begin
  if self = nil then
    raise new ArgumentNullException('self');

  result := integer.MinValue;
  var oddFound := false;
  var rowsCount := self.GetLength(0);
  var colsCount := self.GetLength(1);
  for var i := 0 to rowsCount - 1 do
    for var j := 0 to colsCount - 1 do
      if (result < self[i, j]) and (self[i, j] mod 2 <> 0) then
      begin
        result := self[i, j];
        oddFound := true;
      end;

  if not oddFound then
    raise new ArgumentException('self');
end;

begin
  Matr.Rand(Base.ReadInt32('N:'), Base.ReadInt32('M:'), -27, 38).Print().Max().Println();
  Base.ReadChar();
end.