#include <stdio.h>
void main()
{
	int data[]={8,11,17,21,28,32,36,47},key,len,begin,end,mid;
	len=sizeof(data)/sizeof(int);
	begin=0;end=len-1;
	printf("Enter the key to be searched: ");
	scanf("%d",&key);
	while (begin<=end)
	{
		mid=(begin+end)/2;
		if (key>data[mid]) begin=mid+1;
		else if (key<data[mid]) end=mid-1;
		else {
			printf("The index of the key is %d\n",mid);
			break;
		}
	}
	if (begin>end) printf("The key is not found!\n");
}