#include<stdio.h>
#include <conio.h>
int main()
{	unsigned int low,high, /**/temp   /**/;
	printf("Please input 2 positive integers:");
	scanf("%u%u",&low, &high);
	if(high<low)
	{	temp=high;
		/**/high=low;   /**/
		low=temp;
	}
	for(temp=low;temp<=high;temp++)
		if(temp%2==/**/0   /**/)	printf("%u ",temp);
	printf("\n");
	getch();
	return 0;
}
