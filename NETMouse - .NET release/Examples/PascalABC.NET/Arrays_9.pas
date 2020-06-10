// Работает только начиная с ABCNET 0.0.15 - проблема в PascalABC.NET - сбоит со вложенными типами.
{$reference ABCNET.dll}
uses ABCNET.Utils;
uses ABCNET.Extensions;
begin
  Arr.Rand(BaseU.ReadInteger('N:'), -20, 25).Println().Numerate().MinBy(x -> x.Item).Index.Println();
  BaseU.ReadChar();
end.