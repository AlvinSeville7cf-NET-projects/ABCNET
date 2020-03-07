{$reference ABCNET.dll}
uses ABCNET.Utils;
uses ABCNET.Extensions;
begin
  Arr.Rand(Base.ReadInt32('N:'), -23, 34).Println();
  Base.ReadChar();
end.