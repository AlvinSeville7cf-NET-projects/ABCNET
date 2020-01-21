{$reference ABCNET.dll}
uses ABCNET.Utils;
uses ABCNET.Extensions;
begin
  Matr.Rand(Base.ReadInteger('N:'), Base.ReadInteger('M:'), -20, 25).Print();
end.