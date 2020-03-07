{$reference ABCNET.dll}
uses ABCNET.Utils;
uses ABCNET.Extensions;
begin
  Arr.ReadInt32(Base.ReadInt32('N:'), 'Элемент {0}-ый:').Where((x, i) -> i mod 2 = 0).Prod().Println();
  Base.ReadChar();
end.