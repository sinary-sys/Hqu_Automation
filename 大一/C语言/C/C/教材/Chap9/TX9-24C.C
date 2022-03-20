#include <stdio.h>
void swap(void *a,void *b,int size) {
	char temp;
	int i;
	for (i=0;i<size;i++) {
		temp=*((char*)a);
		*((char*)a)=*((char*)b);
		*((char*)b)=temp;
		a=(char*)a+1;
		b=(char*)b+1;
	}
}
void main(void) {
	char s1[20]="abcdef",s2[20]="12345678";
	int i=10,j=20;
	double x=3.5,y=-4.5;

	swap(s1,s2,sizeof(s1));
	printf("s1=%s,s2=%s\n",s1,s2);

	swap(&i,&j,sizeof(int));
	printf("i=%d,j=%d\n",i,j);

	swap(&x,&y,sizeof(double));
	printf("x=%lf,y=%lf\n",x,y);
}