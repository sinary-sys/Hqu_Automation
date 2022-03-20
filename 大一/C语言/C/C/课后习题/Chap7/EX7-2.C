#include <stdio.h>
#define N 10
void main()
{
	int i,age[N],oldest=0,total=0;
	printf("Enter the age of ten students: ");
	for (i=0;i<N;i++)
	{
		scanf("%d",&age[i]);
		if (age[i]>oldest) oldest=age[i];
		total+=age[i];
	}
	printf("The oldest one is %d years old.\n",oldest);
	printf("The average age is %d years old.\n",total/N);
}