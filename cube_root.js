function cubeRoot(y) {
    let x = 1;
    let delta = y

    while (delta > -x*x) {
        x = (2*x + (y / x**2)) / 3;
        delta -= x;
    }

    return x;
}
