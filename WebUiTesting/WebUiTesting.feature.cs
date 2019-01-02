﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace WebUiTesting
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Web UI Testing", new string[] {
            "WebUiTesting",
            "SearchByIngredients"}, SourceFile="WebUiTesting.feature", SourceLine=1)]
    public partial class WebUITestingFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "WebUiTesting.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Web UI Testing", null, ProgrammingLanguage.CSharp, new string[] {
                        "WebUiTesting",
                        "SearchByIngredients"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Search by Ingredients should reload the page when you click on the Recipe Puppy l" +
            "ogo", SourceLine=8)]
        public virtual void SearchByIngredientsShouldReloadThePageWhenYouClickOnTheRecipePuppyLogo()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search by Ingredients should reload the page when you click on the Recipe Puppy l" +
                    "ogo", null, ((string[])(null)));
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 10
 testRunner.Given("I go to the Search by Ingredients page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
  testRunner.And("I enter a value of \'apple\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.When("I click the Recipe Puppy logo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then("the search field is equal to \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Search by Ingredients should not search if no ingredients are provided", SourceLine=16)]
        public virtual void SearchByIngredientsShouldNotSearchIfNoIngredientsAreProvided()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search by Ingredients should not search if no ingredients are provided", null, ((string[])(null)));
#line 17
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 18
 testRunner.Given("I go to the Search by Ingredients page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
  testRunner.And("I enter a value of \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.When("I attempt to perform a search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.Then("no search was performed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Search by Ingredients should return no results if ingredient is not broad enough", SourceLine=24)]
        public virtual void SearchByIngredientsShouldReturnNoResultsIfIngredientIsNotBroadEnough()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search by Ingredients should return no results if ingredient is not broad enough", null, ((string[])(null)));
#line 25
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 26
 testRunner.Given("I go to the Search by Ingredients page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 27
  testRunner.And("I enter a value of \'x\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.When("I perform a search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.Then("no results were returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Search by Ingredients should return an error message if can\'t understand the ingr" +
            "edient provided", SourceLine=32)]
        public virtual void SearchByIngredientsShouldReturnAnErrorMessageIfCantUnderstandTheIngredientProvided()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search by Ingredients should return an error message if can\'t understand the ingr" +
                    "edient provided", null, ((string[])(null)));
#line 33
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 34
 testRunner.Given("I go to the Search by Ingredients page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 35
  testRunner.And("I enter a value of \'xyz\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.When("I perform a search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.Then("couldn\'t understand the ingredient", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Search by Ingredients should search by keyword instead if can\'t understand the in" +
            "gredient provided", SourceLine=40)]
        public virtual void SearchByIngredientsShouldSearchByKeywordInsteadIfCantUnderstandTheIngredientProvided()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search by Ingredients should search by keyword instead if can\'t understand the in" +
                    "gredient provided", null, ((string[])(null)));
#line 41
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 42
 testRunner.Given("I go to the Search by Ingredients page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 43
  testRunner.And("I enter a value of \'test\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.When("I perform a search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
 testRunner.Then("searched for value \'test\' as a keyword instead", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Search by Ingredients should return results for ingredients that contain numbers", SourceLine=48)]
        public virtual void SearchByIngredientsShouldReturnResultsForIngredientsThatContainNumbers()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search by Ingredients should return results for ingredients that contain numbers", null, ((string[])(null)));
#line 49
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 50
 testRunner.Given("I go to the Search by Ingredients page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 51
  testRunner.And("I enter a value of \'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.When("I perform a search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
 testRunner.Then("the results should contain a value of \'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Search by Ingredients should return results for ingredients that are not case sen" +
            "sitive", SourceLine=56)]
        public virtual void SearchByIngredientsShouldReturnResultsForIngredientsThatAreNotCaseSensitive()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search by Ingredients should return results for ingredients that are not case sen" +
                    "sitive", null, ((string[])(null)));
#line 57
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 58
 testRunner.Given("I go to the Search by Ingredients page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 59
  testRunner.And("I enter a value of \'APPLE\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
 testRunner.When("I perform a search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
 testRunner.Then("the results should contain a value of \'apple\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Search by Ingredients should return results for a valid ingredient that contain s" +
            "paces", SourceLine=64)]
        public virtual void SearchByIngredientsShouldReturnResultsForAValidIngredientThatContainSpaces()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search by Ingredients should return results for a valid ingredient that contain s" +
                    "paces", null, ((string[])(null)));
#line 65
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 66
 testRunner.Given("I go to the Search by Ingredients page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 67
  testRunner.And("I enter a value of \'brown sugar\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
 testRunner.When("I perform a search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 69
 testRunner.Then("the results should contain a value of \'brown sugar\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Search by Ingredients should return results for only the first ingredient for an " +
            "invalid ingredient with spaces", SourceLine=72)]
        public virtual void SearchByIngredientsShouldReturnResultsForOnlyTheFirstIngredientForAnInvalidIngredientWithSpaces()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search by Ingredients should return results for only the first ingredient for an " +
                    "invalid ingredient with spaces", null, ((string[])(null)));
#line 73
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 74
 testRunner.Given("I go to the Search by Ingredients page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 75
  testRunner.And("I enter a value of \'apple pie\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
 testRunner.When("I perform a search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
 testRunner.Then("the results should contain a value of \'apple\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 78
  testRunner.And("the search field is equal to \'apple,\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Search by Ingredients should return valid results for single ingredients", SourceLine=81)]
        public virtual void SearchByIngredientsShouldReturnValidResultsForSingleIngredients()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search by Ingredients should return valid results for single ingredients", null, ((string[])(null)));
#line 82
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 83
 testRunner.Given("I go to the Search by Ingredients page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 84
  testRunner.And("I enter a value of \'apple\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
 testRunner.When("I perform a search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 86
 testRunner.Then("the results should contain a value of \'apple\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Search by Ingredients should return valid results for multiple ingredients", SourceLine=89)]
        public virtual void SearchByIngredientsShouldReturnValidResultsForMultipleIngredients()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search by Ingredients should return valid results for multiple ingredients", null, ((string[])(null)));
#line 90
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 91
 testRunner.Given("I go to the Search by Ingredients page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 92
  testRunner.And("I enter a value of \'apple, sugar, flour\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
 testRunner.When("I perform a search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 94
 testRunner.Then("the ingredients should contain a value of \'apple\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 95
  testRunner.And("the ingredients should contain a value of \'sugar\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
  testRunner.And("the ingredients should contain a value of \'flour\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Search by Ingredients should keep the previous searched for ingredients in the se" +
            "arch bar", SourceLine=99)]
        public virtual void SearchByIngredientsShouldKeepThePreviousSearchedForIngredientsInTheSearchBar()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search by Ingredients should keep the previous searched for ingredients in the se" +
                    "arch bar", null, ((string[])(null)));
#line 100
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 101
 testRunner.Given("I go to the Search by Ingredients page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 102
  testRunner.And("I enter a value of \'apple\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
 testRunner.When("I perform a search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 104
 testRunner.Then("the search field is equal to \'apple,\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Search by Ingredients should include a drop-down menu for valid ingredients", SourceLine=110)]
        public virtual void SearchByIngredientsShouldIncludeADrop_DownMenuForValidIngredients()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search by Ingredients should include a drop-down menu for valid ingredients", null, ((string[])(null)));
#line 111
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 112
 testRunner.Given("I go to the Search by Ingredients page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 113
 testRunner.When("I enter a value of \'apple\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 114
 testRunner.Then("the search drop-down contains \'apple\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Search by Ingredients should add ingredients selected via the drop-down menu to t" +
            "he search bar", SourceLine=117)]
        public virtual void SearchByIngredientsShouldAddIngredientsSelectedViaTheDrop_DownMenuToTheSearchBar()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search by Ingredients should add ingredients selected via the drop-down menu to t" +
                    "he search bar", null, ((string[])(null)));
#line 118
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 119
 testRunner.Given("I go to the Search by Ingredients page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 120
  testRunner.And("I enter a value of \'apple\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
 testRunner.When("I select the drop-down value of \'apple\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 122
 testRunner.Then("the search field is equal to \'apple,\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
