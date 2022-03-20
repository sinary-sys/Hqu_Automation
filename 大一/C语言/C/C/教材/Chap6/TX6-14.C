#include <stdio.h>
void main()
{
	int nd=0;
	char c;
	while (1) {
		if ((c=getchar())=='b')
			if ((c=getchar())=='y')
				if ((c=getchar())=='e')
					break;
		if (c>='0' && c<='9') nd++;
	}
	printf("There are %d digits.\n",nd);
}