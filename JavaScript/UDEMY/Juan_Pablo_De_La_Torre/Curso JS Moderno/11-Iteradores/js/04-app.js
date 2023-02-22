let i = 1;

while (i <= 100) {
  if (i % 5 == 0 && i % 3 == 0) {
    console.log(`${i} Fizzbuzz`);
  }
  if (i % 3 == 0) {
    console.log(`${i} fizz`);
  } else if (i % 5 == 0) {
    console.log(`${i} buzz`);
  }

  i++; //Incremento
}
