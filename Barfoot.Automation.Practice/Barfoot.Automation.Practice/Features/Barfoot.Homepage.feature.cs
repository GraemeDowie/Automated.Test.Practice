﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Barfoot.Automation.Practice.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Barfoot Homepage Test Examples")]
    public partial class BarfootHomepageTestExamplesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Barfoot.Homepage.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Barfoot Homepage Test Examples", "A selection of Automated tests of the homepage for Barfoot&T", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 4
#line 5
 testRunner.Given("user has visited the Barfoot homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User can see the top navbar options")]
        [NUnit.Framework.TestCaseAttribute("Buy", null)]
        [NUnit.Framework.TestCaseAttribute("Sell", null)]
        [NUnit.Framework.TestCaseAttribute("Rent", null)]
        [NUnit.Framework.TestCaseAttribute("Commercial", null)]
        [NUnit.Framework.TestCaseAttribute("Projects", null)]
        [NUnit.Framework.TestCaseAttribute("Property Management", null)]
        [NUnit.Framework.TestCaseAttribute("Body Corporate", null)]
        [NUnit.Framework.TestCaseAttribute("About us", null)]
        [NUnit.Framework.TestCaseAttribute("Careers", null)]
        [NUnit.Framework.TestCaseAttribute("Market reports", null)]
        [NUnit.Framework.TestCaseAttribute("News", null)]
        [NUnit.Framework.TestCaseAttribute("Find us", null)]
        public virtual void UserCanSeeTheTopNavbarOptions(string topNavOptions, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User can see the top navbar options", exampleTags);
#line 7
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 8
 testRunner.Then(string.Format("user can see the top nav bar options {0}", topNavOptions), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User selects Auckland City from the region tab then performs a search")]
        public virtual void UserSelectsAucklandCityFromTheRegionTabThenPerformsASearch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User selects Auckland City from the region tab then performs a search", ((string[])(null)));
#line 26
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "regionAC"});
            table1.AddRow(new string[] {
                        "Auckland City"});
#line 27
 testRunner.When("User selects Auckland City from the region tab", ((string)(null)), table1, "When ");
#line 30
  testRunner.And("presses the search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.Then("User should see returned property results for Auckland City", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion