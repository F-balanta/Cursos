// Fizzbuzz

// Si el numero es multiplo de 3 imrimira Fizz
// Si es multiplo 5 imprimira buzz
// Si es multiplo de ambos imprimira fizzbuzz

for (let i = 1; i <= 100; i++) {
  if (i % 5 == 0 && i % 3 == 0) {
    console.log(`${i} Fizzbuzz`);
  }
  if (i % 3 == 0) {
    console.log(`${i} fizz`);
  } else if (i % 5 == 0) {
    console.log(`${i} buzz`);
  }
}
