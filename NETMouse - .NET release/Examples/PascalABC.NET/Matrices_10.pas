{$reference ABCNET.dll}
uses ABCNET.Utils;
uses ABCNET.Extensions;
begin
  Matr.Gen(3, 3, (i, j) -> i + 1).Print();
end.