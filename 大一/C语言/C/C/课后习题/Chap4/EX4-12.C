#include <stdio.h>
void main()
{
	int a,b,c;
	printf("Please input three numbers: ");
	scanf("%d%d%d",&a,&b,&c);
	printf("Your numbers forward: \n");
	printf("%d\n%d\n%d\n",a,b,c);
	printf("Your numbers reversed: \n");
	printf("%d\n%d\n%d\n",c,b,a);
}