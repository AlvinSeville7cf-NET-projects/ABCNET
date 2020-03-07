{$reference ABCNET.dll}
uses ABCNET.Utils;
uses ABCNET.Extensions;
uses System;

function Sum(self: array [,] of integer): array of integer; extensionmethod;
begin
  if self = nil then
    raise new ArgumentNullException('self');

  result := new integer[self.GetLength(0)];
  var rowsCount := self.GetLength(0);
  var colsCount := self.GetLength(1);
  for var i := 0 to rowsCount - 1 do
    for var j := 0 to colsCount - 1 do
      result[i] += self[i, j];
end;

begin
  Matr.ReadInt32(Base.ReadInt32('N:'), Base.ReadInt32('M:'), 'Элемент ({0}, {1})-ый:').Sum().Println();
  Base.ReadChar();
end.