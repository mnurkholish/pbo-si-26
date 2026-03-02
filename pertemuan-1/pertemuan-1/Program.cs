Console.WriteLine("Masukkan nilai : ");
int nilai = int.Parse(Console.ReadLine());
int nilai_lain = 0;

//string nama = Console.ReadLine();


if (nilai >= 80 || nilai_lain >= 10) {
    Console.WriteLine("Anda mendapat nilai A");
}
else if (nilai >= 70 && nilai_lain >= 10) {
    Console.WriteLine("Anda mendapat nilai B");
}
else if (nilai >= 60) {
    Console.WriteLine("Anda mendapat nilai C");
}
else {
    Console.WriteLine("Yahh remedial");
}

int angka = 1;

switch (angka) {
    case 1:
        Console.WriteLine("satu");
        break;
    case 2:
        Console.WriteLine("dua");
        break;
    default:
        Console.WriteLine("Tidak valid");
        break;
}

for (int i = 5; i >= 1; i--) {
    Console.WriteLine($"Iterasi ke-{i}");
    i--;
}

int j = 0;
while (j < 0) {
    Console.WriteLine("Iterasi While ke-" + j);
    j++;
}

j = 0;
do {
    Console.WriteLine("Iterasi Do-While ke-" + j);
    j++;
} while (j < 0);

string[] hobi = { "Coding", "Gaming", "Reading" };

foreach (string item in hobi) {
    Console.WriteLine("Hobi: " + item);
}

for (int i = 0; i < hobi.Count(); i++) {
    Console.WriteLine(hobi[i]);
}

List<string> products = ["Laptop", "Keyboard", "Kamera"];

foreach (string item in products) {
    Console.WriteLine("Product: " + item);
}

for (int i = 0; i < products.Count(); i++) {
    Console.WriteLine(products[i]);
}