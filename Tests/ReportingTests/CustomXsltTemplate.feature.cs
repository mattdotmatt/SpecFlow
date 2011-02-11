// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.3.2.0
//      Runtime Version:4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace ReportingTests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Using custom XSLT template for reports")]
    public partial class UsingCustomXSLTTemplateForReportsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CustomXsltTemplate.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Using custom XSLT template for reports", "In order to customize the look of the specflow reports\r\nAs a test manager\r\nI want" +
                    " to be able to specify a custom XSLT template for the report generation", ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Specfiy custom XSLT for NUnit execution report")]
        public virtual void SpecfiyCustomXSLTForNUnitExecutionReport()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Specfiy custom XSLT for NUnit execution report", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
testRunner.Given("there are NUnit test execution results for the ReportingTest.SampleProject projec" +
                    "t");
#line hidden
#line 8
testRunner.And("there is an XSLT template containing", @"  <xsl:template match=""/"">
	features: <xsl:value-of select=""count(//nunit:test-suite[(child::nunit:results/nunit:test-case)])""/>
	all: <xsl:value-of select=""count(//nunit:test-case)""/>
	success: <xsl:value-of select=""count(//nunit:test-case[@executed = 'True' and @success='True'])""/>
	failure: <xsl:value-of select=""count(//nunit:test-case[@executed = 'True' and @success='False' and nunit:failure])""/>
	pending: <xsl:value-of select=""count(//nunit:test-case[@executed = 'True' and @success='False' and not(nunit:failure)])""/>
	ignored: <xsl:value-of select=""count(//nunit:test-case[@executed = 'False'])""/>
  </xsl:template>	", ((TechTalk.SpecFlow.Table)(null)));
#line 19
testRunner.When("I generate SpecFlow NUnit execution report with the custom XSLT");
#line hidden
#line 20
testRunner.Then("a report generated like", "\tfeatures: 2\r\n\tall: 5\r\n\tsuccess: 2\r\n\tfailure: 1\r\n\tpending: 1\r\n\tignored: 1", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Custom XSLT can include other custom XSLT")]
        public virtual void CustomXSLTCanIncludeOtherCustomXSLT()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Custom XSLT can include other custom XSLT", ((string[])(null)));
#line 30
this.ScenarioSetup(scenarioInfo);
#line 31
testRunner.Given("there are NUnit test execution results for the ReportingTest.SampleProject projec" +
                    "t");
#line hidden
#line 32
testRunner.And("there is an XSLT template \'custominclude.xslt\' containing", "  <xsl:template name=\"custom-template\">\r\n\tthis was generated by a custom template" +
                    "\r\n\tfeatures: <xsl:value-of select=\"count(//nunit:test-suite[(child::nunit:result" +
                    "s/nunit:test-case)])\"/>\r\n  </xsl:template>\t", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 39
testRunner.And("there is an XSLT template containing", "  <xsl:include href=\"custominclude.xslt\"/>\r\n  \r\n  <xsl:template match=\"/\">\r\n\t<xsl" +
                    ":call-template name=\"custom-template\" />\r\n  </xsl:template>\t", ((TechTalk.SpecFlow.Table)(null)));
#line 47
testRunner.When("I generate SpecFlow NUnit execution report with the custom XSLT");
#line hidden
#line 48
testRunner.Then("a report generated like", "\tthis was generated by a custom template\r\n\tfeatures: 2", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Custom XSLT can include built-in SpecFlow XSLT")]
        public virtual void CustomXSLTCanIncludeBuilt_InSpecFlowXSLT()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Custom XSLT can include built-in SpecFlow XSLT", ((string[])(null)));
#line 55
this.ScenarioSetup(scenarioInfo);
#line 56
testRunner.Given("there are NUnit test execution results for the ReportingTest.SampleProject projec" +
                    "t");
#line hidden
#line 57
testRunner.And("there is an XSLT template containing", @"  <xsl:include href=""resource://TechTalk.SpecFlow.Reporting/TechTalk/SpecFlow/Reporting/Common/Common.xslt""/>
  
  <xsl:template match=""/"">
	the english tool text for 'GeneratedByPre' is
	<xsl:call-template name=""get-common-tool-text"">
         <xsl:with-param name=""text-key"" select=""'GeneratedByPre'"" />
	</xsl:call-template>
  </xsl:template>	", ((TechTalk.SpecFlow.Table)(null)));
#line 68
testRunner.When("I generate SpecFlow NUnit execution report with the custom XSLT");
#line hidden
#line 69
testRunner.Then("a report generated like", "\tthe english tool text for \'GeneratedByPre\' is\r\n\tGenerated by SpecFlow at ", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Custom XSLT can include built-in SpecFlow and custom XSLT")]
        public virtual void CustomXSLTCanIncludeBuilt_InSpecFlowAndCustomXSLT()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Custom XSLT can include built-in SpecFlow and custom XSLT", ((string[])(null)));
#line 75
this.ScenarioSetup(scenarioInfo);
#line 76
testRunner.Given("there are NUnit test execution results for the ReportingTest.SampleProject projec" +
                    "t");
#line hidden
#line 77
testRunner.And("there is an XSLT template \'custominclude.xslt\' containing", "  <xsl:template name=\"custom-template\">\r\n\tthis was generated by a custom template" +
                    "\r\n\tfeatures: <xsl:value-of select=\"count(//nunit:test-suite[(child::nunit:result" +
                    "s/nunit:test-case)])\"/>\r\n  </xsl:template>\t", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 84
testRunner.And("there is an XSLT template containing", @"  <xsl:include href=""custominclude.xslt""/>
  <xsl:include href=""resource://TechTalk.SpecFlow.Reporting/TechTalk/SpecFlow/Reporting/Common/Common.xslt""/>
  
  <xsl:template match=""/"">
	the english tool text for 'GeneratedByPre' is
	<xsl:call-template name=""get-common-tool-text"">
         <xsl:with-param name=""text-key"" select=""'GeneratedByPre'"" />
	</xsl:call-template>
	<xsl:call-template name=""custom-template"" />
  </xsl:template>	", ((TechTalk.SpecFlow.Table)(null)));
#line 97
testRunner.When("I generate SpecFlow NUnit execution report with the custom XSLT");
#line hidden
#line 98
testRunner.Then("a report generated like", "\tthe english tool text for \'GeneratedByPre\' is\r\n\tGenerated by SpecFlow at \r\n\tthis" +
                    " was generated by a custom template\r\n\tfeatures: 2", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion