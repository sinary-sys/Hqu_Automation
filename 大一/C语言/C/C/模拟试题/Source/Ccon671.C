#include<stdio.h>
#include <conio.h>
int main()
{	int n,an,an_1, an_2,i;
	long sum= 2;
	an_1=1;
	an_2= /**/1   /**/;
	printf("Input n(2<n<30):");
	scanf("%d",&n);
	for(i=/**/3   /**/; i<=n; i++)
	{	an=an_1+an_2;
		sum+=/**/an    /**/;
		an_2=an_1;
		an_1=an;
	}
	printf("sum=%ld\n",sum);
	getch();
	return 0;
}
