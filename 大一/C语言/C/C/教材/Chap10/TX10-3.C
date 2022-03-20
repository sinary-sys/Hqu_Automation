#include <stdio.h>
#define TED 10
void main(void) {
	#ifdef TED
		printf("Hi Ted\n");
	#else
		printf("Hi anyone\n");
	#endif
	#ifndef RALPH
		printf("RALPH not defined\n");
	#endif
}