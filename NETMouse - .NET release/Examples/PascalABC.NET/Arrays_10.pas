{$reference ABCNET.dll}
uses ABCNET.Utils;
uses ABCNET.Extensions;
begin
  Arr.ReadInteger(BaseU.ReadInteger('N:'), 'Элемент {0}-ый:').Where(x -> x = 0).Count().Println();
  BaseU.ReadChar();
end.