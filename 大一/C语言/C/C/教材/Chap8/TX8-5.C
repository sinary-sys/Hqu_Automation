#include <stdio.h>
void swap(int a,int b)
{
	int temp;
	temp=a;
	a=b;
	b=temp;
	printf("In function swap: ");
	printf("a=%d,b=%d\n",a,b);
}
void main()
{
	int m,n;
	printf("Input m and n: ");
	scanf("%d%d",&m,&n);
	swap(m,n);
	printf("In function main: ");
	printf("m=%d,n=%d\n",m,n);
}