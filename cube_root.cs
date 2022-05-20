class Program {
    static float cubeRoot(y) {
        float x = 1;
        float delta = y;

        while (delta > -x*x) {
            x = (2*x + (y / x**2)) / 3;
        }

        return x;
    }
}
