// See https://aka.ms/new-console-template for more information

//Stack overflow beobachten

void doit(int i,int j)
{
    doit(i++,j++);
}
doit(1,1);