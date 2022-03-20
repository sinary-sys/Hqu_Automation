#include <stdio.h>
void hanoi(int n,int first,int second,int third)
{
	if (n==1) printf("%d-->%d\n",first,third);
	else {
		hanoi(n-1,first,third,second);
		printf("%d-->%d\n",first,third);
		hanoi(n-1,second,first,third);
	}
}
void main()
{
	int n;
	printf("Enter the number of plates: ");
	scanf("%d",&n);
	hanoi(n,1,2,3);
}