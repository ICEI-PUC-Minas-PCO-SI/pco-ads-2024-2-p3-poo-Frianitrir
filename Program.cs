
        Carro carro = new Carro("Civic");
        carro.setQtdePortas(4);
        carro.setCinto("5");

        Console.WriteLine("Carro:");
        carro.Mostrar();
        Console.WriteLine();

        //PICAPE
        Picape picape = new Picape();
        picape.setQtdePortas(2);
        picape.setNCacamba(1);
        picape.setNCabine(2);

        Console.WriteLine("Picape:");
        picape.Mostrar();
        Console.WriteLine();

        //MOTO
        Moto moto = new Moto();
        moto.setGuidao("Sim");
        moto.setGarupa("Sim");

        Console.WriteLine("Moto:");
        moto.Mostrar();
        Console.WriteLine();

        //MOTOCROSS
        Motocross motocross = new Motocross();
        motocross.setGuidao("Sim");
        motocross.setNCorrente(1);
        motocross.setNCavalete(1);

        Console.WriteLine("Motocross:");
        motocross.Mostrar();
        Console.WriteLine();

        //SEDAN
        Sedan sedan = new Sedan("BYD");
        sedan.setQtdePortas(4);

        Console.WriteLine("Sedan:");
        sedan.Mostrar();
        Console.WriteLine();

        //SCOOTER
        Scooter scooter = new Scooter();
        scooter.setGuidao("Sim");
        scooter.setNBau(1);

        Console.WriteLine("Scooter:");
        scooter.Mostrar();