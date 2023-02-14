import java.util.*;
import java.util.concurrent.TimeUnit;

public class Main {
    public static void main(String[] args) {
        var rand = new Random();
        int numN = 5000;

        var list = new ArrayList<Integer>(numN);

        var sb = new StringBuilder();
        for (int i = 0; i < numN; i++) {
            var num = rand.nextInt(numN);
            sb.append(num + " ");
        }

        //String inputString = "1 4 2 6 3 4";
        //String inputString = "1 2 1 2 1 2 4 2 6 3 2 1 4";
        //String inputString = "1 1 1 1 1";
        //System.out.println(inputString);

        String inputString = sb.toString();
        System.out.println("Input: " + inputString.substring(0,50));


        List<Integer> resultSlow = Slow(inputString);

        long startTime = System.currentTimeMillis();
        List<Integer> resultFast = Fast(inputString);
        long endTime = System.currentTimeMillis();
        long elapsedTime = endTime - startTime;

        if (!resultSlow.equals(resultFast)) {
            System.out.println("Error!!! Not Equal results!");
        }

        System.out.println("Max Jumps: " + Collections.max(resultSlow));
        System.out.println("Jumps: " + resultSlow.subList(0, Math.min(20, resultSlow.size())));

        System.out.println("Execution Time: " + elapsedTime);
    }

    public  static  List<Integer> Fast(String inputNumbers){
        int[] numbers = CreateIntArray(inputNumbers);
        int numN = numbers.length;

        var jumps = new int[numN];
        int maxValue = numbers[numbers.length - 1];
        for (int i = jumps.length - 2; i >= 0; i--) {
            int current = numbers[i];
            boolean stop = false;
            for (int j = i+1; j < numbers.length; j++) {
                int next = numbers[j];
                if (current < next){
                    jumps[i] = jumps[j]+1;
                    stop = true;
                } else if (current == next){
                    jumps[i] = jumps[j];
                    stop = true;
                }

                if (stop){
                    break;
                }
            }
        }
        
        List<Integer> result = new ArrayList<>(jumps.length);
        for (int i = 0; i < jumps.length; i++) {
            result.add(jumps[i]);
        }
        
        return  result;
    }

    public  static ArrayList<Integer> Slow(String inputNumbers){
        int[] numbers = CreateIntArray(inputNumbers);
        int numN = numbers.length;

        int initialJump = 0;
        int next = 0;

        var list = new ArrayList<Integer>(numN);

        int counter = 0;
        int max = Arrays.stream(numbers).max().getAsInt();
        for (int i = 0; i < numN; i++) {
            initialJump = numbers[i];
            // partial optimization
            if(initialJump == max){
                list.add(0);
                continue;
            }
            for (int j = i + 1; j < numN; j++) {
                next = numbers[j];
                if (initialJump < next){
                    counter++;
                    initialJump = next;
                }
            }
            list.add(counter);
            counter = 0;
        }

        return list;
    }

    private static  int[] CreateIntArray(String input){
        //var numbers = inputNumbers.Trim().Split().Select(int.Parse).ToArray();
        String[] numbersInString = input.trim().split(" ");
        int[] numbers = new int[numbersInString.length];
        for (int i = 0; i < numbersInString.length; i++) {
            numbers[i] = Integer.parseInt(numbersInString[i]);
        }

        return numbers;
    }
}