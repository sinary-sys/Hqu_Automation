#include <stdio.h>
void main()
{
	int API;
	printf("Input API: ");
	scanf("%d",&API);
	if (API>=0 && API<=50) printf("Excellent!\n");
	else if (API>=51 && API<=99) printf("Good!\n");
	else if (API>=100 && API<=199) printf("Slightly polluted!\n");
	else if (API>=200 & API<=299) printf("Moderately polluted!\n");
	else printf("Severly polluted!\n");
}