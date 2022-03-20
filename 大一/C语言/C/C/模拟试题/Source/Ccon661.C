#include <stdio.h>
#include <conio.h>
unsigned long  Calcul(unsigned int n,unsigned int m)
{	unsigned int i;
	unsigned long result;
	result=/**/1   /**/;
	for(i=n;i>=n-m+1;i--)
		result*=/**/i   /**/;
	return result;
}
int main()
{	unsigned int /**/m,n     /**/;
	printf("Please input 2 positive integers n and m (0<m<n<10):");
	scanf("%u%u",&n,&m);
	printf("Calcul(%u,%u)=%lu\n",n,m, Calcul(n,m));
	getch();
	return 0;
}