{$reference ABCNET.dll}
uses ABCNET.Utils;
uses ABCNET.Extensions;
uses System;

function Min(self: array [,] of integer): (integer, integer); extensionmethod;
begin
  if self = nil then
    raise new ArgumentNullException('self');

  var _min := integer.MaxValue;
  var minRow := 0;
  var rowsCount := self.GetLength(0);
  var colsCount := self.GetLength(1);
  for var i := 0 to rowsCount - 1 do
    for var j := 0 to colsCount - 1 do
      if _min > self[i, j] then
      begin
        _min := self[i, j];
        minRow := i;
      end;
  
  result := (_min, minRow);
end;

begin
  Matr.ReadInt32(Base.ReadInt32('N:'), Base.ReadInt32('M:'), 'Элемент ({0}, {1})-ый:').Min().Println();
  Base.ReadChar();
end.