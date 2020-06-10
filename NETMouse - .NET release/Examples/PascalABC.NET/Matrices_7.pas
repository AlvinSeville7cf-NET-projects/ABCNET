{$reference ABCNET.dll}
uses ABCNET.Utils;
uses ABCNET.Extensions;
begin
  Matr.Gen(4, 4, (i, j) -> i = j ? 1 : 0).Print();
  BaseU.ReadChar();
end.