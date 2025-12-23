using System;
using System.Collections.Generic;

// 1. Sealed Security Class
sealed class Security
{
    public void Authenticate()
    {
        Console.WriteLine("User authenticated successfully");
    }
}

// 2. Abstract Base Class
abstract class InsurancePolicy
{
    // Init-only property
    public int PolicyNumber { get; init; }

    // Encapsulated premium with validation
    private double premium;
    public double Premium
    {
        get { return premium; }
        set
        {
            if (value > 0)
                premium = value;
        }
    }

    public string PolicyHolderName { get; set; }

    // Virtual method
    public virtual double CalculatePremium()
    {
        return Premium;
    }

    // Base display method
    public void ShowPolicy()
    {
        Console.WriteLine("Insurance Policy");
    }
}

// 3a. Life Insurance
class LifeInsurance : InsurancePolicy
{
    public override double CalculatePremium()
    {
        return Premium + 500; // fixed life insurance charge
    }

    // Method hiding
    public new void ShowPolicy()
    {
        Console.WriteLine("Life Insurance Policy");
    }
}

// 3b. Health Insurance
class HealthInsurance : InsurancePolicy
{
    public sealed override double CalculatePremium()
    {
        return Premium + 2000;
    }
}

// 4. Policy Directory with Indexers
class PolicyDirectory
{
    private List<InsurancePolicy> policies = new List<InsurancePolicy>();

    public void AddPolicy(InsurancePolicy policy)
    {
        policies.Add(policy);
    }

    // Indexer by index
    public InsurancePolicy this[int index]
    {
        get { return policies[index]; }
    }

    // Indexer by policy holder name
    public InsurancePolicy this[string name]
    {
        get
        {
            foreach (var policy in policies)
            {
                if (policy.PolicyHolderName == name)
                    return policy;
            }
            return null;
        }
    }
}

// 5. Main Program
class Program
{
    static void Main()
    {
        // Authentication
        Security security = new Security();
        security.Authenticate();

        // Create policies
        LifeInsurance life = new LifeInsurance
        {
            PolicyHolderName = "Amit",
            PolicyNumber = 101,
            Premium = 5000
        };

        HealthInsurance health = new HealthInsurance
        {
            PolicyHolderName = "Neha",
            PolicyNumber = 102,
            Premium = 6000
        };

        // Policy directory
        PolicyDirectory directory = new PolicyDirectory();
        directory.AddPolicy(life);
        directory.AddPolicy(health);

        // Indexer usage
        Console.WriteLine(directory[0].PolicyHolderName);
        Console.WriteLine(directory["Neha"].PolicyNumber);

        // Runtime polymorphism
        InsurancePolicy p1 = life;
        InsurancePolicy p2 = health;

        Console.WriteLine("Life Premium: " + p1.CalculatePremium());
        Console.WriteLine("Health Premium: " + p2.CalculatePremium());

        // Method hiding demonstration
        life.ShowPolicy();   // Derived reference
        p1.ShowPolicy();     // Base reference
    }
}
