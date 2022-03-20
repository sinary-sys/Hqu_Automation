#include <stdio.h>
#include <stdlib.h>
#define N 20
void main()
{
	int i,no,number[N],exist[N]={0};
	randomize();
	for (i=0;i<N;i++)
	{
		do {
			no=rand()%N;
		}while (exist[no]==1);
		number[i]=no;
		exist[no]=1;
		printf("%4d",number[i]);
		if ((i+1)%10==0) printf("\n");
	}
}