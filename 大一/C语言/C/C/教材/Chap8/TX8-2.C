#include <stdio.h>
long sum(int n,int m) {
	long total=0l,term=n;
	int i;
	for (i=1;i<=m;i++)
	{
		total+=term;
		term=term*10+n;
	}
	return total;
}
void message()
{
	printf("Waiting for calculating the sum...\n");
}
void main()
{
	int n,m;
	printf("Enter n and m: ");
	scanf("%d%d",&n,&m);
	message();
	printf("The sum is %d\n",sum(n,m));
}