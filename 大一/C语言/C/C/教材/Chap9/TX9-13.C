#include <stdio.h>
void swap(int *p1,int *p2) {
	int p;
	p=*p1;
	*p1=*p2;
	*p2=p;
}
void main(void) {
	int a[]={1,2,3,4,5},len=sizeof(a)/sizeof(int),*front=a,*rear=a+len-1,k;
	for (;front<rear;front++,rear--)
		swap(front,rear);
	for (k=0;k<len;k++) printf("%4d",a[k]);
	printf("\n");
}