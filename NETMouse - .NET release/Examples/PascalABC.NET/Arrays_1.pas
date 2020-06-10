{$reference ABCNET.dll}
uses ABCNET.Utils;
uses ABCNET.Extensions;
begin
  Arr.Rand(BaseU.ReadInteger('N:'), -23, 34).Println();
  BaseU.ReadChar();
end.