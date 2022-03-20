#include <stdio.h>
void main(void) {
	int a[10],no,i,j,k,len=0,temp;
	printf("Input ten integers: \n");
	for (i=0;i<10;i++)
	{
		scanf("%d",&no);
		for (j=0;j<len;j++)
			if (no<a[j]) break;
		for (k=len-1;k>=j;k--) a[k+1]=a[k];
		a[j]=no;
		len++;
	}

	for (i=0;i<10;i++) printf("%4d",a[i]);
	printf("\n");
}