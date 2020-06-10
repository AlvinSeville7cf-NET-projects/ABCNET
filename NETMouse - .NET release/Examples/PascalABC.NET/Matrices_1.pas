{$reference ABCNET.dll}
uses ABCNET.Utils;
uses ABCNET.Extensions;
begin
  Matr.Rand(BaseU.ReadInteger('N:'), BaseU.ReadInteger('M:'), -20, 25).Print();
  BaseU.ReadChar();
end.