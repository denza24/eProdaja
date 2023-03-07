import 'package:eprodajamobile/models/product.dart';
import 'package:eprodajamobile/providers/product_provider.dart';
import 'package:eprodajamobile/utils/util.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class ProductListScreen extends StatefulWidget {
  const ProductListScreen({super.key});

  static const String routeName = '/products';

  @override
  State<ProductListScreen> createState() => _ProductListScreenState();
}

class _ProductListScreenState extends State<ProductListScreen> {
  List<Product> productList = [];
  ProductProvider? productProvider;

  @override
  void initState() {
    super.initState();
    productProvider = context.read<ProductProvider>();
    loadData();
  }

  Future loadData() async {
    var data = await productProvider!.get(null);
    setState(() {
      productList = data;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(title: const Text('Products')),
        body: Column(
          children: [
            const SizedBox(
              height: 40,
            ),
            Center(child: _buildProductCardList()),
          ],
        ));
  }

  Widget _buildProductCardList() {
    if (productList.isEmpty) {
      return const CircularProgressIndicator();
    }
    var products = productList
        .map((p) => Column(
              children: [
                SizedBox(
                  height: 100,
                  width: 100,
                  child: p.slika != '' ? imageFromBase64String(p.slika) : null,
                ),
                Text(
                  p.naziv,
                  style: const TextStyle(fontSize: 20),
                )
              ],
            ))
        .toList();

    return SizedBox(
      height: 250,
      child: GridView(
          gridDelegate: const SliverGridDelegateWithFixedCrossAxisCount(
              crossAxisCount: 1, childAspectRatio: 4 / 3, mainAxisSpacing: 30),
          scrollDirection: Axis.horizontal,
          children: products),
    );
  }
}
