#include <stdio.h>
#include <conio.h>

int main()
{ int /**/a1=2,a2=1,a3;/**/
  double sum;
  int i;
  sum=1.0*a1/a2;
  for(/*i=1*/i=2; i<=20; i++)
  { a3=a1+a2;
    a2=a1;
    a1=a3;
	sum+=/* a1/a2 */(double)a1/a2;
  }
  printf("sum=%lf\n",sum);
  getch();
  return 0;
}