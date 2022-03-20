#include <stdio.h>
void copy_string(char *to,const char *from) {
	while (*to++=*from++);
}
void main(void) {
	char a[20]="c language";
	char b[20]="very good";
	copy_string(a,b);
	printf("a=%s\n",a);
	printf("b=%s\n",b);
}