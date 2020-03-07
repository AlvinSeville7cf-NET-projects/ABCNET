{$reference ABCNET.dll}
uses ABCNET.Utils;
uses ABCNET.Extensions;
begin
  Matr.Rand(Base.ReadInt32('N:'), Base.ReadInt32('M:'), -20, 25).Print();
  Base.ReadChar();
end.