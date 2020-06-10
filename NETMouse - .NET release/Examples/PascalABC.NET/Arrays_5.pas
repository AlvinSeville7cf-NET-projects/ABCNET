{$reference ABCNET.dll}
uses ABCNET.Utils;
uses ABCNET.Extensions;
begin
  Arr.ReadInteger(BaseU.ReadInteger('N:'), 'Элемент {0}-ый:').Where((x, i) -> i mod 2 = 0).Sum().Println();
  BaseU.ReadChar();
end.