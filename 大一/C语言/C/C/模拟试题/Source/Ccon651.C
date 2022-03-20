#include <stdio.h>
#include <conio.h>
void LettersPrint(int n)
{ int line,letter,space;
  char ch=/**/'A'    /**/;
  for(line=1; /**/line<=n     /**/; line++)
  { for(space=1; space<=n-line ; space++ )  printf(" ");
	for(letter=1; letter<=2*line-1; letter++)  printf("%c", /**/ch   /**/);
    ch++;
    printf("\n");
  }
}

int main()
{ int n;
  printf("Please input n (0<n<20):");
  scanf("%d",&n);
  LettersPrint(n);
  getch();
  return 0;
}

