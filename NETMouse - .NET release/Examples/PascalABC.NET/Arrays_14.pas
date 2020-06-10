{$reference ABCNET.dll}
uses ABCNET.Utils;
uses ABCNET.Extensions;
begin
  var a := Arr.ReadInteger(BaseU.ReadInteger('N:'), 'Элемент {0}-ый:');
  var b := a.Where(x -> x mod 2 = 0).ToArray();
  BaseU.ReadChar();
end.