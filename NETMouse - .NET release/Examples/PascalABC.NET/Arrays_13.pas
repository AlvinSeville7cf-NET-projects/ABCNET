{$reference ABCNET.dll}
uses ABCNET.Utils;
uses ABCNET.Extensions;
begin
  Arr.ReadInteger(BaseU.ReadInteger('N:'), 'Элемент {0}-ый:').Where((x, i) -> i mod 2 = 0).Aggregate((a, b) -> a * b).Println();
  BaseU.ReadChar();
end.