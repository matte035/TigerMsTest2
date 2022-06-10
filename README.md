# MSUnitTestProjekt

Jag skall testa vår kod och några utav våra kritiska delar av projektet.

Jag har valt att testa "Deposit metoden", "CreateNewBankAccount metoden", "Remove account metoden/CreateN".


Deposit metoden :
I detta test så kollar jag hur det blir när en användare sätter in pengar på ett nytt konto. 

Vad kan gå fel här?:
Om kunden väljer en valuta som inte finns i bankensregister så går inte testet genom.
Om kunden väljer en negativ valuta så går inte testen genom.


CreateNewBankAccount metoden:
Om du vill ha ditt konto i en valuta som inte finns , detta skall jag testa.

Vad kan gå fel här?:
Om du skapar ett konto med samma namn så kommer det inte att fungera.


Remove account metoden:
Här bygger mitt test på metoden vad som sker när man tar bort en användare efter lagt till ett konto. Så jag testar två metoder i ett test. 


Vad kan gå fel här?:

Det ska inte kunna gå att ta bort ett konto förutom det man väljer i testet.
