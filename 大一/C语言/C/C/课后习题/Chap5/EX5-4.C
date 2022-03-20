#include <stdio.h>
void main()
{
	int a,b,c;
	printf("Input three integers: ");
	scanf("%d%d%d",&a,&b,&c);
	if (a>=b)
	{
		if (b>=c) printf("%d>%d>%d\n",a,b,c);
		else if (a>=c) printf("%d>%d>%d\n",a,c,b);
		else printf("%d>%d>%d\n",c,a,b);
	}else if (a>c) printf("%d>%d>%d\n",b,a,c);
	else if (c>b) printf("%d>%d>%d\n",c,b,a);
	else printf("%d>%d>%d\n",b,c,a);
}