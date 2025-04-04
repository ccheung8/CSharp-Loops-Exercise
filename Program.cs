for (int row = 0; row < 6; row++) { 
  for (int col = 0; col < (5 - row); col++) {
    Console.Write(" ");
  }
  for (int col = 0; col < row + row + 1; col++) {
  Console.Write("*");
  }
  Console.WriteLine();
}