#include <stdio.h>
#include <conio.h>
long fun(int n)
{ /**/

	if£¨n==1 || n==2) return 1;
	else return fun(n-2)+fun(n-1);



 /**/
}

void main()
{ int n;
  printf("Input n(n>=1): ");
  scanf("%d",&n);
  printf("fun(%d) =%ld \n ",n,fun(n));
  getch();
}

