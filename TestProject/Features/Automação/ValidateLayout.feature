Feature:Validate Page Layout

@falhou
Scenario: Validate image size
	Given I access the site "www.ailos.com.br"
	When I watch the new image and
	Then I confirm that your size is correct

@passou
Scenario: Validate field name
	Given I access the site "www.ailos.com.br"
	When I watch the field name and
	Then I confirm that it is written correctly