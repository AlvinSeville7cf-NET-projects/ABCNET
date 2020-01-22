{$reference ABCNET.dll}
uses ABCNET.Utils;
uses ABCNET.Extensions;
begin
  Arr.ReadInteger(Base.ReadInteger('N:'), 'Элемент {0}-ый:').Where((x, i) -> i mod 2 = 0).Sum().Println();
  Base.ReadChar();
end.