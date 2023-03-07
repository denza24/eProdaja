import 'package:eprodajamobile/providers/product_provider.dart';
import 'package:eprodajamobile/screens/product/product_list_screen.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MultiProvider(
      providers: [ChangeNotifierProvider(create: (_) => ProductProvider())],
      child: MaterialApp(
        title: 'Flutter Demo',
        theme: ThemeData(
          primarySwatch: Colors.blue,
        ),
        onGenerateRoute: (settings) {
          if (settings.name == ProductListScreen.routeName) {
            return MaterialPageRoute(
                builder: ((context) => const ProductListScreen()));
          }
          return null;
        },
        home: const MyHomePage(),
      ),
    );
  }
}

class MyHomePage extends StatelessWidget {
  const MyHomePage({super.key});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        body: SingleChildScrollView(
      child: Column(
        children: [
          Container(
              height: 450,
              decoration: const BoxDecoration(
                  image: DecorationImage(
                      fit: BoxFit.fill,
                      image: AssetImage("assets/images/background.png"))),
              child: Stack(
                children: [
                  Positioned(
                      top: 0,
                      left: 120,
                      width: 80,
                      height: 160,
                      child: Container(
                        decoration: const BoxDecoration(
                            image: DecorationImage(
                                image:
                                    AssetImage("assets/images/light-1.png"))),
                      )),
                  Positioned(
                      top: 40,
                      right: 40,
                      width: 80,
                      height: 120,
                      child: Container(
                        decoration: const BoxDecoration(
                            image: DecorationImage(
                                image: AssetImage("assets/images/clock.png"))),
                      )),
                  const Center(
                    child: Text(
                      'Login',
                      style: TextStyle(
                          fontSize: 40,
                          color: Colors.white,
                          fontWeight: FontWeight.bold),
                    ),
                  ),
                ],
              )),
          Padding(
            padding: const EdgeInsets.fromLTRB(40, 80, 40, 0),
            child: Column(
              children: [
                Container(
                  padding: const EdgeInsets.fromLTRB(10, 0, 10, 0),
                  decoration: BoxDecoration(
                      borderRadius: BorderRadius.circular(10),
                      color: Colors.white),
                  child: Column(children: [
                    Container(
                      padding: const EdgeInsets.all(8),
                      decoration: const BoxDecoration(
                          border:
                              Border(bottom: BorderSide(color: Colors.grey))),
                      child: const TextField(
                        decoration: InputDecoration(
                            hintText: 'Email or Phone number',
                            border: InputBorder.none,
                            hintStyle: TextStyle(color: Colors.grey)),
                      ),
                    ),
                    Container(
                      padding: const EdgeInsets.all(8),
                      child: const TextField(
                        obscureText: true,
                        decoration: InputDecoration(
                            hintText: 'Password',
                            border: InputBorder.none,
                            hintStyle: TextStyle(color: Colors.grey)),
                      ),
                    ),
                  ]),
                ),
                const SizedBox(
                  height: 100,
                ),
                Container(
                  width: 350,
                  height: 50,
                  decoration: BoxDecoration(
                      borderRadius: BorderRadius.circular(5),
                      gradient: const LinearGradient(colors: [
                        Color.fromRGBO(100, 108, 255, 1),
                        Color.fromRGBO(178, 182, 250, 1)
                      ])),
                  child: InkWell(
                    onTap: () => {
                      Navigator.pushNamed(context, ProductListScreen.routeName),
                    },
                    child: const Center(
                        child: Text('Login',
                            style:
                                TextStyle(fontSize: 20, color: Colors.white))),
                  ),
                ),
                Container(
                  padding: const EdgeInsets.fromLTRB(0, 20, 0, 0),
                  child: const Text('Forgot password?'),
                )
              ],
            ),
          ),
        ],
      ),
    ));
  }
}
