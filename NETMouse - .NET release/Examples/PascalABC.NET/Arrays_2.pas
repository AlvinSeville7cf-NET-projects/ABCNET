{$reference ABCNET.dll}
uses ABCNET.Utils;
uses ABCNET.Extensions;
begin
  Arr.ReadInt32(Base.ReadInt32('N:'), 'Элемент {0}-ый:').Prod().Println();
  Base.ReadChar();
end.