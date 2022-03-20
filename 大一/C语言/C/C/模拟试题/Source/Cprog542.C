#include <stdio.h>
#include <conio.h>
int fun(int x)
{ /**/  
	int div;
	if (x<10) div=10;
	else if (x<100) div=100;
	else div=1000;

	if (x*x%div==x) return 1;
	else return 0;
  /**/
}

void main()
{ int i;  
  for(i=1;i<1000;i++)
     if(fun(i))
        printf("%5d",i);
  getch();
}
