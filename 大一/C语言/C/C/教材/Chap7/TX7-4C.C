#include <stdio.h>
void main()
{
	int data[]={77,38,42,65,59,82,93,74,48,89},i,j,len,pos,temp;
	len=sizeof(data)/sizeof(int);
	printf("Begin sorting: \n");
	for (i=0;i<len-1;i++)
	{
		pos=i;
		for (j=i+1;j<len;j++)
			if (data[j]<data[pos])
				pos=j;
		if (pos!=i) {
			temp=data[i];
			data[i]=data[pos];
			data[pos]=temp;
		}
		for (j=0;j<len;j++)
			if (j==i) printf("%3d|",data[j]);
			else printf("%3d ",data[j]);
		printf("\n");
	}
	printf("After sorting: \n");
	for (i=0;i<len;i++)
		printf("%4d",data[i]);
	printf("\n");
}