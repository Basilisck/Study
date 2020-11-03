program fibonachi;
var a, b, c, c1, c2, i:integer;
begin
  c:=1;
  c1:=1;
  c2:=0;
  writeln('Введите колличество элементов чисел Фибоначи');
  readln(a);
  for b:=0 to a do
    begin
      c:=c1;
      c1:=c2+c1;
      c2:=c;
      write(c,' ')
    end;
  readln;
end.
