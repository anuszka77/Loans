# Warszat

## �wiczenie 1

1. Utw�rz klas� `LoanTermShould`
2. Napisz test kt�ry zweryfikuje czy `LoanTerm.ToMonths()` zwraca 12.

## �wiczenie 2

1. W klasie `LoanTermShould` utw�rz test kt�ry sprawdzi czy propery `Years` jest ustawione na 1.


---

## �wiczenie 3

1. Sprawd� czy dwie instancje `LoanTerm` (`ValueObject`) s� sobie r�wne je�eli warto�ci parametru Years s� sobie r�wne.
2. Zakomentuj metody `Equals()` oraz `GetHashCode` i uruchom jeszcze raz test.

## �wiczenie 4

1. Por�wnaj dwie instancje LoanTerm pod k�tem referencji (`Is.Not.SameAs()`)
2. Utw�rz trzeci� zmienn� wskazuj�c� na referencj� pierwszej (`Is.SameAs`).

## �wiczenie 5

1. Utw�rz por�wnaj dwie listy string�w utworzone przy pomocy `new List<string>`.
2. Utw�rz trzeci� zmienn� wskazuj�c� na pierwsz� list� i je por�wnaj.

---

## �wiczenie 6
1. Zmie� np. metod� `LoanTerm().ToYears` modyfikuj�c kod tak aby zwr�ci� niepoprawn� ilo�� miesi�cy.
2. Zedytuj pierwszy test wykorzystuj�c przeci��on� metod� asercji, kt�ra wy�wietli customowy komunikat.
3. Uruchom test i zweryfikuj wiadomo�� w konsoli.


---

## �wiczenie 7 - Kolekcje
1. Przetestuj metod� `ProductComparer.CompareMonthlyRepayments()`
2. �eby utworzy� instancj� ProductComparer, musisz utworzy�:
   - list� produkt�w po�yczek (`LoanProduct`) - stw�rz trzy unikalne
   - now� po�yczk� (`LoanAmount`)
3. Metoda `CompareMonthlyRepayments` zwraca list� i potrzebuje jako parametr warunk�w: `new LoanTerm(30)` (po�yczka na 30 lat)
4. Sprawd� asercj� czy lista zwr�cona przez `CompareMonthlyRepayments` zwraca tyle samo element�w ile mamy w li�cie LoadProduct (z punktu 2)


## �wiczenie 8 - Kolekcje
1. Przetestuj metod� `ProductComparer.CompareMonthlyRepayments()`
2. �eby utworzy� instancj� ProductComparer, musisz utworzy�:
   - list� produkt�w po�yczek (`LoanProduct`) - stw�rz trzy
   - now� po�yczk� (`LoanAmount`)
3. Metoda `CompareMonthlyRepayments` zwraca list� i potrzebuje jako parametr warunk�w: `new LoanTerm(30)` (po�yczka na 30 lat)
4. Sprawd� asercj� czy lista zwr�cona przez `CompareMonthlyRepayments` zwraca unikalne elementy


## �wiczenie 8 - Kolekcje
1. Przetestuj metod� `ProductComparer.CompareMonthlyRepayments()`
2. �eby utworzy� instancj� ProductComparer, musisz utworzy�:
   - list� produkt�w po�yczek (`LoanProduct`) - stw�rz trzy
   - now� po�yczk� (`LoanAmount`)
3. Metoda `CompareMonthlyRepayments` zwraca list� i potrzebuje jako parametr warunk�w: `new LoanTerm(30)` (po�yczka na 30 lat)
4. Sprawd� asercj� czy lista zwr�cona przez `CompareMonthlyRepayments` zwraca odpowiednie warto�ci dla pierwszego elementu



## �wiczenie 8 - Kolekcje
1. Przetestuj metod� `ProductComparer.CompareMonthlyRepayments()`
2. �eby utworzy� instancj� ProductComparer, musisz utworzy�:
   - list� produkt�w po�yczek (`LoanProduct`) - stw�rz trzy
   - now� po�yczk� (`LoanAmount`)
3. Metoda `CompareMonthlyRepayments` zwraca list� i potrzebuje jako parametr warunk�w: `new LoanTerm(30)` (po�yczka na 30 lat)
4. Sprawd� asercj� czy lista zwr�cona przez `CompareMonthlyRepayments` zwraca odpowiednie warto�ci w pierwszym elemencie (sprawd� dok�adnie property `ProductName` oraz `InterestRate`, dla property MonthlyRepayment jest wi�ksza ni� 0)


---

## �wiczenie 9 - �apanie wyj�tk�w
1. Napisz test kt�ry z�apie wyj�tek z klasy LoanTerm.
2. Dla `LoanTerm(0)` powinni�my otrzyma� `ArgumentOutOfRangeException`


---

## �wiczenie 10 - Inne asercje