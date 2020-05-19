%Facts
man('Michael').
man('Alejandro').
man('Johnathan').
man('Samuel').
man('Jack').
man('Justin').
man('Arnold').
man('Thomas').
woman('Hannah').
woman('Emma').
woman('Kate').
woman('Tiffany').
woman('Elsa').
woman('Megan').
woman('Angelina').
parent('Hannah','Michael').
parent('Hannah','Alejandro').
parent('Johnathan','Michael').
parent('Johnathan','Alejandro').
parent('Michael', 'Kate').
parent('Emma', 'Kate').
parent('Elsa','Emma').
parent('Elsa','Tiffany').
parent('Tiffany','Justin').
parent('Jack','Emma').
parent('Jack','Tiffany').
parent('Michael','Sam').
parent('Emma','Sam').
parent('Jack','Emma').
parent('Thomas','Megan').
parent('Megan','Angelina').
parent('Justin','Angelina').
parent('Arnold','Justin').
marriage('Emma','Michael').
marriage('Hannah','Johnathan').
marriage('Elsa','Jack').
marriage('Megan','Justin').
marriage('Tiffany','Arnold').

%Rules
father(X,Y):-man(X), parent(X,Y).
mother(X,Y):-woman(X),parent(X,Y).
husband_mother(X,Y):-mother(X,Z),marriage(Y,Z),woman(Y).
wife_mother(X,Y):-mother(X,Z),marriage(Y,Z),man(Y).
brother(X,Y):-man(X),parent(Z,X),parent(Z,Y),not(X=Y).
sister(X,Y):-woman(X),parent(Z,X),parent(Z,Y),not(X=Y).
uncle(X,Y):-man(X),brother(X,Z),parent(Z,Y).
aunt(X,Y):-woman(X),brother(X,Z),parent(Z,Y).
grandpa(X,Y):-man(X),parent(X,Z),parent(Z,Y). 
grandma(X,Y):-woman(X),parent(X,Z),parent(Z,Y).
bro_or_sis(X,Y):-parent(Z,X),parent(Z,Y),not(X=Y).
cousin(X,Y):-parent(Z,X),parent(A,Y),bro_or_sis(Z,A).