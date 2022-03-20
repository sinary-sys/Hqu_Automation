#include <stdio.h>
void main()
{
	int data[]={77,38,42,65,59,82,93,74,48,89},i,len,pass,temp,swap;
	len=sizeof(data)/sizeof(int);
	printf("Begin sorting: \n");
	for (pass=1;pass<len;pass++)
	{
		swap=0;
		for (i=0;i<len-pass;i++)
			if (data[i]>data[i+1])
			{
				temp=data[i];
				data[i]=data[i+1];
				data[i+1]=temp;
				swap=1;
			}
		if (!swap) break;
		for (i=0;i<len;i++)
			if (i==len-pass) printf("|%3d",data[i]);
			else printf("%4d",data[i]);
		printf("\n");
	}
	printf("After sorting: \n");
	for (i=0;i<len;i++)
		printf("%4d",data[i]);
	printf("\n");
}