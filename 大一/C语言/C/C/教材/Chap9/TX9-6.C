#include <stdio.h>
void main(void) {
	int a[]={0,1,2,3,4,5,6,10};
	int *p=a;
	printf("a[0]=%d\n",a[0]);
	printf("*p=%d\n",*p);
	printf("*(p+0)=%d\n",*(p+0));
	printf("p[0]=%d\n",p[0]);

	p+=4;
	printf("a[4]=%d\n",a[4]);
	printf("*p=%d\n",*p);
	printf("p[0]=%d\n",p[0]);
	printf("p[1]=%d\n",p[1]);
	printf("p[-1]=%d\n\n",p[-1]);

	printf("*p++=%d\n",*p++);
/*	printf("*(++p)=%d\n\n",*(++p));*/
	printf("*++p=%d\n\n",*++p);

	printf("(*p)++=%d\n",(*p)++);
	printf("*p=%d\n",*p);
}