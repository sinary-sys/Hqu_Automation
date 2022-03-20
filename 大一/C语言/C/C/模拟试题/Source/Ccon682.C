#include <stdio.h>
#include <conio.h>

int main()
{	int i,x,a,b,c;
	for(i=11; i<=/**/ 30  /**/ ;i++)
	{
		x=i*i;
		c=x%10;
		b=x/10%10;
		a=x/100;
		if(a==b || a==c || /**/ b==c   /**/)
			printf("%d * %d = %d\n",i,i, /**/ i*i   /**/);
	} 
	getch();
	return 0;
}

