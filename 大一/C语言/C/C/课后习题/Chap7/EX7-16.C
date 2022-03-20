#include <stdio.h>
void main(void)
{
	int bin[20],n,i,k=0;
	printf("Enter a positive integer: ");
	scanf("%d",&n);
	while (n>0) {
		bin[k++]=n%2;
		n/=2;
	}
	for (i=k-1;i>=0;i--) printf("%d",bin[i]);
	printf("\n");
}