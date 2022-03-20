#include <stdio.h>
void main()
{
	int data[]={77,38,42,65,59,82,93,74,48,89},i,inserter,pass,pos,len;
	len=sizeof(data)/sizeof(int);
	printf("Begin sorting: \n");
	for (pass=1;pass<len;pass++)
	{
		inserter=data[pass];
		pos=pass-1;
		while (pos>=0 && inserter<data[pos])
		{
			data[pos+1]=data[pos];
			pos--;
		}
		data[pos+1]=inserter;

		for (i=0;i<len;i++)
			if (i==pass) printf("%3d|",data[i]);
			else printf("%3d ",data[i]);
		printf("\n");
	}
	printf("After sorting: \n");
	for (i=0;i<len;i++)
		printf("%4d",data[i]);
	printf("\n");
}