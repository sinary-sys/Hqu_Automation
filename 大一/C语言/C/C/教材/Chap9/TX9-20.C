#include <stdio.h>
int add(int a,int b) {return a+b;}
int sub(int a,int b) {return a-b;}
int mul(int a,int b) {return a*b;}
int div(int a,int b) {
		if (b) return a/b;
		return 0;
}
int mod(int a,int b) {
	if (b) return a%b;
	return 0;
}
int op(int x,int y,int (*pf)(int,int)) {
	int result;
	result=pf(x,y);
	return result;
}

void main(void) {
	int i=100,j=30,k,a[5];
	char s[]={'+','-','*','/','%','\0'};

	int (*p_fun[5])(int,int)={add,sub,mul,div,mod};
	int (**ppf)(int,int)=p_fun;
	for (k=0;k<5;k++) a[k]=op(i,j,ppf[k]);
	for (k=0;k<5;k++) printf("(%d):%d%c%d=%d\n",k+1,i,s[k],j,a[k]);
}