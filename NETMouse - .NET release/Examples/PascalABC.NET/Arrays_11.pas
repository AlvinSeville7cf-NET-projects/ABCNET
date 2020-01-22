{$reference ABCNET.dll}
uses ABCNET.Utils;
uses ABCNET.Extensions;
begin
  Arr.ReadInteger(Base.ReadInteger('N:'), 'Элемент {0}-ый:').Where(x -> x mod 2 = 0).Count().Println();
  Base.ReadChar();
end.