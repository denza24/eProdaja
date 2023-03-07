class Product {
  final int id;
  final String naziv;
  final double cijena;
  final String slika;

  const Product({
    required this.id,
    required this.naziv,
    required this.cijena,
    required this.slika,
  });

  factory Product.fromJson(Map<String, dynamic> json) {
    return Product(
        id: json['proizvodId'],
        naziv: json['naziv'],
        cijena: json['cijena'],
        slika: json['slika']);
  }
}
