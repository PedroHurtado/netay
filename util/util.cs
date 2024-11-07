namespace util{
    
    public static class PrintUtil{
        public static void PrintDate(DateTime date, Action<string?> print) {
            print($"La fecha actual es: {date}");
        }
    }
}