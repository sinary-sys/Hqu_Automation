#include <stdio.h>
void main(void) {
	int a[10],i,pass,swap,temp;
	printf("Input ten integers: \n");
	for (i=0;i<10;i++) scanf("%d",&a[i]);
	for (pass=1;pass<=9;pass++)
	{
		swap=0;
		for (i=0;i<10-pass;i++)
			if (a[i]>a[i+1]) {
				swap=1;
				temp=a[i];
				a[i]=a[i+1];
				a[i+1]=temp;
			}
		if (!swap) break;
	}
	for (i=0;i<10;i++) printf("%4d",a[i]);
	printf("\n");
}