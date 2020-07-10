Feature: Validate Title and Symbol
	
@falhou
Scenario: Validate Title GitHub
	Given I have navigate "www.github.com"
	Then Page title "GitHub"

@passou
Scenario: Validate Title Google
	Given I have navigate "www.google.com"
	Then page title "Google"

@pendente
Scenario: Validate Title Microsoft
	Given I have navigate "www.microsoft.com"
	Then page title "Microsoft"

@automacao
Scenario: Validate Google's Stock Symbol
	Given I have navigated to the "Alphabet_Inc." page on Wikipedia
	Then the NASDAQ stock symbol on the page should be "GOOGL"

@automacao
Scenario: Validate Microsoft's  Stock Symbol
	Given I have navigated to the "Microsoft" page on Wikipedia
	Then the NASDAQ stock symbol on the page should be "MSFT"

@automacao
Scenario: Validate Apple's  Stock Symbol
	Given I have navigated to the "Apple_Inc." page on Wikipedia
	Then the NASDAQ stock symbol on the page should be "AAPL"

@automacao
Scenario: Validate Stock Symbol
	Given I have navigated to the "Apple_Inc." page on Wikipedia
	Then the NASDAQ stock symbol on the page should be "AA"
