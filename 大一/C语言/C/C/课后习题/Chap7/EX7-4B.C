#include <stdio.h>
void main(void) {
	int a[10],i,j,temp;
	printf("Input ten integers: \n");
	for (i=0;i<10;i++) scanf("%d",&a[i]);
	for (i=0;i<9;i++)
		for (j=i+1;j<10;j++)
		{
			if (a[j]<a[i]) {
				temp=a[i];
				a[i]=a[j];
				a[j]=temp;
			}
		}
	for (i=0;i<10;i++) printf("%4d",a[i]);
	printf("\n");
}