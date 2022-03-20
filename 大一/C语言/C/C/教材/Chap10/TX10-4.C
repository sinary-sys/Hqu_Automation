#include <stdio.h>
#define NAME "Tsinghua Uni.\n"
void main(void) {
	#ifdef NAME
		printf(NAME);
	#endif

	#undef NAME
	#ifndef NAME
		printf("NAME doesn't mean Tsinghua Uni.\n");
	#endif
}