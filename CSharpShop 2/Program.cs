using CSharpShop_2;

// CREIAMO L'OGGETTO BOTTIGLIA1
Acqua bottiglia1 = new Acqua("Acqua Gaia", "acqua frizzante", 1, 22, "Genga (AN)", 1, 1.5);

bottiglia1.StampaPrezzoBase();
bottiglia1.StampaPrezzoIva();
bottiglia1.StampaProdotto();

// BEVIAMO DELL'ACQUA
bottiglia1.Bevi(0.5);
bottiglia1.StampaProdotto();

// SVUOTIAMO LA BOTTIGLIA D'ACQUA
bottiglia1.Svuota();
bottiglia1.StampaProdotto();

// RIEMPIAMO LA BOTTIGLIA D'ACQUA
bottiglia1.Riempi(2);
bottiglia1.StampaProdotto();