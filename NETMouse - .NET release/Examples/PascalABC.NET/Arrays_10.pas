{$reference ABCNET.dll}
uses ABCNET.Utils;
uses ABCNET.Extensions;
begin
  Arr.ReadInt32(Base.ReadInt32('N:'), 'Элемент {0}-ый:').Where(x -> x = 0).Count().Println();
  Base.ReadChar();
end.