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

// CREIAMO L'OGGETTO SACHHETTOFRUTTA1

List<string> tipoFrutta = new List<string>() { "Banana", "Uva", "Mela", "Ananas" };
SacchettoFrutta sacchettoFrutta1 = new SacchettoFrutta("Sacchettino", "Sacchetto contenente frutta pronta da mangiare", 4.99, 22, 5, tipoFrutta);

sacchettoFrutta1.StampaPrezzoBase();
sacchettoFrutta1.StampaPrezzoIva();
sacchettoFrutta1.StampaProdotto();

sacchettoFrutta1.Mangia(4);
sacchettoFrutta1.StampaProdotto();

sacchettoFrutta1.Mangia(4);
sacchettoFrutta1.StampaProdotto();

sacchettoFrutta1.AggiungiTipoFrutta("Melone");
sacchettoFrutta1.StampaProdotto();


Elettrodomestico lavatrice = new Elettrodomestico("Samsung LS56V", "Elettrodomestico per il lavaggio degli indumenti", 799.98, 22, "Lavatrice", "Nuovo");

lavatrice.StampaPrezzoBase();
lavatrice.StampaPrezzoIva();
lavatrice.StampaProdotto();

lavatrice.SetCondizione("Usata");
lavatrice.StampaProdotto();

lavatrice.Accendi("lavaggio 60°");
lavatrice.StampaProdotto();

lavatrice.Accendi("ON");
lavatrice.StampaProdotto();

lavatrice.Spegni("OFF");
lavatrice.SetGuasto("SI");
lavatrice.StampaProdotto();