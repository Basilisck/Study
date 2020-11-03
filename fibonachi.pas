program fibonachi;
var a, b, c, c1, c2, i:integer;
begin
  c:=1;
  c1:=1;
  c2:=0;
  writeln('‚¢¥¤¨â¥ ª®««¨ç¥áâ¢® í«¥¬¥­â®¢ ç¨á¥« ”¨¡®­ ç¨');
  readln(a);
  for b:=0 to a-1 do
    begin
      c:=c1;
      c1:=c2+c1;
      c2:=c;
      write(c,' ')
    end;
  readln;
end.
