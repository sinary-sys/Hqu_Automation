#include <stdio.h>
#define LETTER 1
void main(void) {
	char str[20]="I love Beijing",c;
	int i=0;
	#undef LETTER

	while ((c=str[i++])!='\0') {
	#if LETTER
		if (c>='a' && c<='z') c-=32;
	#else
		if (c>='A' && c<='Z') c+=32;
	#endif
		printf("%c",c);
	}
}