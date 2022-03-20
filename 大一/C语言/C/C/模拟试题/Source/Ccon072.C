#include<stdio.h>
double fun(unsigned m,unsigned n)
{
  unsigned i;
  double p=1.0;
  for(i=1;i<=m;i++)
   /**/p=p*i;             /**/
  for(i=1;i<=n;i++)
   /**/p=p/i;             /**/
  for(i=1;i<=m-n;i++)
    p=p/i;
  return p;
}

void main()
{
  clrscr();
  printf("p=%f\n",fun(13,7));
  getch();
}
