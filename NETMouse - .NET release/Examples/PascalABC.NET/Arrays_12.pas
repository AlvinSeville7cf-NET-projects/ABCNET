{$reference ABCNET.dll}
uses ABCNET.Utils;
uses ABCNET.Extensions;
begin
  var c := BaseU.ReadInteger('C:');
  Arr.ReadInteger(10, 'Элемент {0}-ый:').Where(x -> x > c).Average().Println();
  BaseU.ReadChar();
end.