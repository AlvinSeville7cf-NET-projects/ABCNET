{$reference ABCNET.dll}
uses ABCNET.Utils;
uses ABCNET.Extensions;
begin
  Arr.ReadInteger(BaseU.ReadInteger('N:'), 'Элемент {0}-ый:').Sum().Println();
  BaseU.ReadChar();
end.