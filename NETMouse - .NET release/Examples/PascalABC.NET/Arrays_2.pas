{$reference ABCNET.dll}
uses ABCNET.Utils;
uses ABCNET.Extensions;
begin
  Arr.ReadInteger(Base.ReadInteger('N:'), 'Элемент {0}-ый:').Aggregate((a, b) -> a * b).Println();
  Base.ReadChar();
end.