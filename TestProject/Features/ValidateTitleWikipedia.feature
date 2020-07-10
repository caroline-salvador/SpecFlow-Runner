Feature: Validate Title Wikipedia

@automacao
Scenario:  Validate Google's Title
	Given I have navigated to the "Google" page on Wikipedia
	Then the title of the page should be "Google - Wikipedia"

@automacao
Scenario: Validate Microsoft's Title
	Given I have navigated to the "Microsoft" page on Wikipedia
	Then the title of the page should be "Microsoft - Wikipedia"

@automacao
Scenario: Validate Apple's Title
	Given I have navigated to the "Apple" page on Wikipedia
	Then the title of the page should be "Apple - Wikipedia"

