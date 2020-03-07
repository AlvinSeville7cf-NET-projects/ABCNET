{$reference ABCNET.dll}
uses ABCNET.Utils;
uses ABCNET.Extensions;
begin
  var c := Base.ReadInt32('C:');
  Arr.ReadInt32(10, 'Элемент {0}-ый:').Where(x -> x > c).Average().Println();
  Base.ReadChar();
end.