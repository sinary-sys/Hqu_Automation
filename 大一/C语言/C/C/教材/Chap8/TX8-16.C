#include <stdio.h>
void bubble_sort(int data[],int len);
void main()
{
	int a[]={73,64,85,59,92,76,68},i,len=sizeof(a)/sizeof(int);
	printf("Before sorting: ");
	for (i=0;i<len;i++) printf("%4d",a[i]);
	printf("\n");
	bubble_sort(a,len);
	printf("After sorting: ");
	for (i=0;i<len;i++) printf("%4d",a[i]);
	printf("\n");
}
void bubble_sort(int data[],int len) {
	int pass,i,swap,temp;
	for (pass=1;pass<len;pass++)
	{
		swap=0;
		for (i=0;i<len-pass;i++)
			if (data[i]>data[i+1]) {
				temp=data[i];
				data[i]=data[i+1];
				data[i+1]=temp;
				swap=1;
			}
		if (!swap) break;
	}
}