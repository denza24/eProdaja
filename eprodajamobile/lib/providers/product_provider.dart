import 'dart:convert';
import 'dart:io';

import 'package:eprodajamobile/models/product.dart';
import 'package:flutter/material.dart';
import 'package:http/io_client.dart';

class ProductProvider with ChangeNotifier {
  HttpClient client = HttpClient();
  IOClient? http;

  ProductProvider() {
    client.badCertificateCallback = (cert, host, port) => true;
    http = IOClient(client);
  }

  Future<List<Product>> get(dynamic searchObject) async {
    var response =
        await http!.get(Uri.parse('https://10.0.2.2:44360/api/Proizvodi'));

    if (response.statusCode == 200) {
      var data = jsonDecode(response.body);
      var list = data.map((p) => Product.fromJson(p)).cast<Product>().toList();

      return list;
    } else {
      throw Exception('Failed to load products');
    }
  }
}
