{$reference ABCNET.dll}
uses ABCNET.Utils;
uses ABCNET.Extensions;
begin
  Arr.ReadInteger(BaseU.ReadInteger('N:'), 'Элемент {0}-ый:').Min().Println();
  BaseU.ReadChar();
end.