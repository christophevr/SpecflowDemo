Feature: Calculator
	Om berekeningen uit te voeren met twee gehele getallen
	Als calculator
	Kan ik 2 getallen inlezen en de berekening uitvoeren

@Calculator
Scenario Outline: Voer berekeningen uit
	Given een eerste getal <eerstegetal>
	And een tweede getal <tweedegetal>
	And we een <operatie> willen uitvoeren
	When we de berekening uitvoeren
	Then verwachten we <resultaat>
		
	Examples:
	 | eerstegetal | tweedegetal | operatie | resultaat |
	 | 1           | 2           | SOM      | 3         |
	 | -5          | -10         | SOM      | -15       |
	 | 1000        | 1000        | SOM      | 2000      |
	 | 1           | 2           | PRODUCT  | 2         |
	 | -5          | -10         | PRODUCT  | 50        |
	 | 1000        | 1000        | PRODUCT  | 1000000   |