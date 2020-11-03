program fibonachi;
var a, b, c:integer;
begin
  c:=1;
  writeln('Введите колличество элементов чисел Фибоначи');
  readln(a);
  for b:=0 to a do
    begin
      c:=c+2;
      write(c,' ')
    end;
  readln;
end.
