#include <stdio.h>
#include <conio.h>
#define N 4
long fun(int a[N],int b[N])
{ /**/

	int i,result=0;
	for (i=0;i<N;i++)
		result+=a[i]*b[i];

	return result;
 /**/
}

int main()
{
	int a[N]={1,2,-1,2},b[N]={0,1,2,-1};
	printf("Multi=%ld\n",fun(a,b) );
	printf("\n");
	getch();
	return 0;
}
