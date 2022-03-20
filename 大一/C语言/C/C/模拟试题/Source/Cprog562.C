#include <stdio.h>
#include <conio.h>
void fib(int f[], int n)
{ /**/

	int i;
	f[0]=f[1]=1;
	for (i=2;i<n;i++)
		f[i]=f[i-2]+f[i-1];

  /**/
}

void main()
{ int data[32], m, i;
  printf("Enter the number of items: ");
  scanf("%d",&m);
  fib(data,m);
  for(i=0; i<m; i++)
    printf("%5d", data[i]);
  printf("\n");
  getch();
}

