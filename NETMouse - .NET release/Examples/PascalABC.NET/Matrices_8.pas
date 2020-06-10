// Работает только начиная с ABCNET 0.0.15 - проблема в PascalABC.NET - сбоит со вложенными типами.
{$reference ABCNET.dll}
uses ABCNET.Utils;
uses ABCNET.Extensions;
uses System;

function Count(self: array [,] of integer): array of integer; extensionmethod;
begin
  if self = nil then
    raise new ArgumentNullException('self');

  result := new integer[self.GetLength(1)];
  var rowsCount := self.GetLength(0);
  var colsCount := self.GetLength(1);
  for var j := 0 to colsCount - 1 do
    for var i := 0 to rowsCount - 1 do
      if self[i, j] < 0 then
        result[j] += 1;
end;

begin
  Matr.ReadInteger(BaseU.ReadInteger('N:'), BaseU.ReadInteger('M:'), 'Элемент ({0}, {1})-ый:').Count().Numerate().MaxBy(x -> x.Item).Index.Println();
  BaseU.ReadChar();
end.