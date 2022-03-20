#include <stdio.h>
unsigned int result[20]={0},len=0;
void Trans(unsigned int n, unsigned int base)
{
	while (n>0)
	{
		result[len++]=n%base;
		n/=base;
	}
}
void main(void)
{
	int n,base,i;
	printf("Input an integer and the destination base: ");
	scanf("%d%d",&n,&base);
	Trans(n,base);
	switch (base)
	{
		case 2:
		case 8:
			for (i=len-1;i>=0;i--) printf("%u",result[i]);
			printf("\n");
			break;
		case 16:
			for (i=len-1;i>=0;i--) {
				if (result[i]>=10) printf("%c",result[i]-10+'A');
				else printf("%u",result[i]);
			}
	}
}