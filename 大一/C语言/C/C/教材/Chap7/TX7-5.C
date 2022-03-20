#include <stdio.h>
void main()
{
	int data[]={36,17,28,15,21,19,8,32},i,j,len,temp;
	len=sizeof(data)/sizeof(int);

	printf("Before reversed: \n");
	for (i=0;i<len;i++)
		printf("%4d",data[i]);

	for (i=0,j=len-1;i<j;i++,j--)
	{
		temp=data[i];
		data[i]=data[j];
		data[j]=temp;
	}

	printf("After reversed: \n");
	for (i=0;i<len;i++)
		printf("%4d",data[i]);
	printf("\n");
}