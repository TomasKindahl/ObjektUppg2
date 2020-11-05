# ObjektUppg2
Objekt-uppgifter 2:

1. Skapa en klass dictEntry som inneh�ller
   attributen 
   
      string swedish, english;

   L�gg upp en array av dictEntry:s, som inneh�ller
   t.ex.
   
        head    huvud
        see     se
        father  far, pappa
        tree    tr�d
        moon    m�ne
        move    flytta
        city    stad
        
   Skriv kod som skriver ut denna array av dictEntry:s
   t.ex. s� h�r:

        english   swedish
        -------------------
        head      huvud
        see       se
        father    far, pappa
        tree      tr�d
        moon      m�ne
        move      flytta
        city      stad
        -------------------

2. G�r samma sak, men byt ut arrayer mot Listor. Anv�nd
   Add f�r att l�gga upp dictEntry:s i Listan, i st�llet
   f�r att anv�nda en initierare.
   
3. G�r om programmet s� att det l�ser in en fil som
   inneh�ller rader
   
        head#huvud
        see#se
        father#far, pappa
        tree#tr�d
        moon#m�ne
        move#flytta
        city#stad

   som du splittar och l�gger upp i listan av dictEntry:s.

4. Skapa en while-loop s� att du kan bygga ett kommando-
   system liknande som t.ex. den latin-svenska ordlistan.
   
5. Skapa ett l�gg-in-kommando, d�r du kan l�gga in
   dictEntry:s i ordlistan.
   
6. Skapa ett sparakommando, s� att du kan spara ordlistan.

7. Skapa ett ta-bort-kommando s� att du kan ta bort
   felaktiga dictEntry:s.

8. Skapa ett kommando som slumpar fram ett dictEntry,
   skriver ut det engelska ordet, och fr�gar efter svensk
   �vers�ttning. Du f�r d� mata in �vers�ttning, och om
   det var r�tt, s� skriver programmet att det var r�tt,
   annars skriver den att det var fel, och skriver ut
   r�tt �vers�ttning, t.ex. s� h�r:
   
       > test
       Vad �r 'move' p� svenska? m�ne
       Tyv�rr fel! 'move' �r 'flytta' p� svenska.
