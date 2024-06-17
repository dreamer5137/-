import java.util.Scanner;
import java.util.Random;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main
{
    public static void main(String[] args)
    {
        Scanner in = new Scanner(System.in);
        Scanner in1 = new Scanner(System.in);
        int cows=0,bulls=0;
        System.out.println("Введите длину числа");
        int dlina = in.nextInt();
        int [] m = new int[dlina];
        Random rnd = new Random();
        String str;
        if (dlina < 11)
        {
            System.out.println("Включить/Выключить повторяющиеся цифры?");
            str = in1.nextLine();
        }
        else
        {
            str = "Выключить";
        }
        if (str.equals("Включить"))
        {
            for(int i=0;i<m.length;i++)
            {
                m[i] = rnd.nextInt(10);
            }
            System.out.println("Число загаданно");
            for(int y=0;y<m.length;y++)
            {
                System.out.print(m[y]);
            }
        }
        else if (str.equals("Выключить"))
        {
            for(int i=0;i<m.length;i++)
            {
                for(int j=0;j!=100;)
                {
                    int a = rnd.nextInt(10);
                    String poisk="";
                    for (int y=0;y<m.length;y++)
                    {
                        if (m[y]==a)
                        {
                            poisk = "Da";
                        }
                    }
                    if(poisk.equals("Da"))
                    {
                        j++;
                    }
                    else
                    {
                        m[i] = a;
                    }
                }
            }
            System.out.println("Число загаданно");
            for(int y=0;y<m.length;y++)
            {
                System.out.print(m[y]);
            }
        }
       for (int y=0;y<100;y++)
      {
            System.out.println("Введите число");
            Scanner in2 = new Scanner(System.in);
            String vvod = in2.nextLine();
            String[] da = vvod.split("");
            for (int j=0;j<m.length;j++)
            {

                for(int h=0;h<da.length;h++)
                {
                    if (String.valueOf(m[j]).equals(da[j]))
                    {
                        bulls++;
                        break;
                    }
                    else
                        if (String.valueOf(m[j]).equals(da[h]))
                    {
                        cows++;
                        break;
                    }
                }
            }
            if(dlina==bulls)
            {
                System.out.println("Поздравляем, число угаданно!");
                break;
            }
            else
            {
                String c,b;
                if(cows < 5 && cows > 1)
                {
                    c=" коровы";
                }
                else
                    if (cows!=1)c=" коров";
                    else c = " корова";
                if (bulls <5 && bulls >1)
                {
                    b=" быка";
                }
                else
                    if(bulls!=1) b = " быков";
                    else b = " бык";
                System.out.println(cows + c + " и " + bulls +b);
                cows=0;
                bulls=0;
            }
      }
    }
}